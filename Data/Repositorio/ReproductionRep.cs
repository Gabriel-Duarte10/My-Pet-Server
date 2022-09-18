using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using My_Pet.Data.Context;
using My_Pet.Data.Dto;
using My_Pet.Data.Interfaces;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Data.Repositorio
{
    public class ReproductionRep : IReproduction
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ReproductionRep(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task Post(ReproductionRequest model)
        {
            var query = _mapper.Map<Reproduction>(model);

            query.CreatedAt = DateTime.Now;

            await _context.Reproduction.AddAsync(query);
            
            await _context.SaveChangesAsync();
        }
        public async Task Put(ReproductionRequest model)
        {
            var query = _mapper.Map<Reproduction>(model);

            query.UpdatedAt = DateTime.Now;

            _context.Reproduction.Update(query);

            await _context.SaveChangesAsync();
        }
        public async Task<List<ReproductionDTO>> GetAll()
        {
            var query = await _context.Reproduction.Where(x => x.DeleteAt == null).ToListAsync();
           
           return _mapper.Map<List<ReproductionDTO>>(query);
        }
        public async Task<ReproductionDTO> GetById(int id)
        {
            var query = await _context.Reproduction.Where(x => x.DeleteAt == null && x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<ReproductionDTO>(query);
        }
        public async Task Delete(int id)
        {
            _context.Reproduction.Where(x => x.Id == id).FirstOrDefault().DeleteAt = DateTime.Now;
            
            await _context.SaveChangesAsync();
        }

        public async Task PostImages(int id, List<ImageDto> imagesDto)
        {
            foreach (var i in imagesDto)
            {
                await _context.ReproductionImage.AddAsync(new ReproductionImage(){
                    id = id,
                    urlImageFireBase = i.UrlImage,
                    nameImageFireBase = i.NameImage
                });   
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<ReproductionImage>> GetAllImages(int id)
        {
           return await _context.ReproductionImage.Where(x => x.id == id).ToListAsync();
        }

        public async Task DeleteImages(int id)
        {
            var images = await _context.ReproductionImage.Where(x => x.id == id).ToListAsync();
            _context.ReproductionImage.RemoveRange(images);
            await _context.SaveChangesAsync();
        }
    }
}