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
    public class RescueRep : IRescue
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public RescueRep(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task Post(RescueRequest model)
        {
            var query = _mapper.Map<Rescue>(model);

            query.CreatedAt = DateTime.Now;

            await _context.Rescue.AddAsync(query);
            
            await _context.SaveChangesAsync();
        }
        public async Task Put(RescueRequest model)
        {
            var query = _mapper.Map<Rescue>(model);

            query.UpdatedAt = DateTime.Now;

            _context.Rescue.Update(query);

            await _context.SaveChangesAsync();
        }
        public async Task<List<RescueDTO>> GetAll()
        {
            var query = await _context.Rescue.Where(x => x.DeleteAt == null).ToListAsync();
           
           return _mapper.Map<List<RescueDTO>>(query);
        }
        public async Task<RescueDTO> GetById(int id)
        {
            var query = await _context.Rescue.Where(x => x.DeleteAt == null && x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<RescueDTO>(query);
        }
        public async Task Delete(int id)
        {
            _context.Rescue.Where(x => x.Id == id).FirstOrDefault().DeleteAt = DateTime.Now;
            
            await _context.SaveChangesAsync();
        }

        public async Task PostImages(int id, List<ImageDto> imagesDto)
        {
            foreach (var i in imagesDto)
            {
                await _context.RescueImage.AddAsync(new RescueImage(){
                    id = id,
                    urlImageFireBase = i.UrlImage,
                    nameImageFireBase = i.NameImage
                });   
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<RescueImage>> GetAllImages(int id)
        {
           return await _context.RescueImage.Where(x => x.id == id).ToListAsync();
        }

        public async Task DeleteImages(int id)
        {
            var images = await _context.RescueImage.Where(x => x.id == id).ToListAsync();
            _context.RescueImage.RemoveRange(images);
            await _context.SaveChangesAsync();
        }
    }
}