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
    public class AdoptionRep: IAdoption
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public AdoptionRep(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task Post(AdoptionRequest model)
        {
            var query = _mapper.Map<Adoption>(model);
            
            query.CreatedAt = DateTime.Now;
            
            await _context.Adoption.AddAsync(query);
            
            await _context.SaveChangesAsync();
        }
        public async Task Put(AdoptionRequest model)
        {
            var query = _mapper.Map<Adoption>(model);

            query.UpdatedAt = DateTime.Now;

            _context.Adoption.Update(query);

            await _context.SaveChangesAsync();
        }
        public async Task<List<AdoptionDTO>> GetAll()
        {
           var query = await _context.Adoption.Where(x => x.DeleteAt == null).ToListAsync();
           return _mapper.Map<List<AdoptionDTO>>(query); 
        }

        public async Task<AdoptionDTO> GetById(int id)
        {
            var query = await _context.Adoption.Where(x => x.DeleteAt == null && x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<AdoptionDTO>(query);
        }
        public async Task Delete(int id)
        {
            _context.Adoption.Where(x => x.Id == id).FirstOrDefault().DeleteAt = DateTime.Now;
            
            await _context.SaveChangesAsync();           
        }

        public async Task PostImages(int id, List<ImageDto> imagesDto)
        {
            foreach (var i in imagesDto)
            {
                await _context.AdoptionImage.AddAsync(new AdoptionImage(){
                    idAdoption = id,
                    urlImageFireBase = i.UrlImage,
                    nameImageFireBase = i.NameImage
                });   
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<AdoptionImage>> GetAllImages(int id)
        {
           return await _context.AdoptionImage.Where(x => x.idAdoption == id).ToListAsync();
        }

        public async Task DeleteImages(int id)
        {
            var images = await _context.AdoptionImage.Where(x => x.idAdoption == id).ToListAsync();
            _context.AdoptionImage.RemoveRange(images);
            await _context.SaveChangesAsync();
        }

    }
}