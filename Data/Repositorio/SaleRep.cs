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
    public class SaleRep : ISale
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public SaleRep(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task Post(SaleRequest model)
        {
            var query = _mapper.Map<Sale>(model);

            query.CreatedAt = DateTime.Now;

            await _context.Sale.AddAsync(query);
            
            await _context.SaveChangesAsync();
        }
        public async Task Put(SaleRequest model)
        {
            var query = _mapper.Map<Sale>(model);

            query.UpdatedAt = DateTime.Now;

            _context.Sale.Update(query);

            await _context.SaveChangesAsync();
        }
        public async Task<List<SaleDTO>> GetAll()
        {
            var query = await _context.Sale.Where(x => x.DeleteAt == null).ToListAsync();
           
           return _mapper.Map<List<SaleDTO>>(query);
        }
        public async Task<SaleDTO> GetById(int id)
        {
            var query = await _context.Sale.Where(x => x.DeleteAt == null && x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<SaleDTO>(query);
        }
        public async Task Delete(int id)
        {
            _context.Sale.Where(x => x.Id == id).FirstOrDefault().DeleteAt = DateTime.Now;
            
            await _context.SaveChangesAsync();
        }

        public async Task PostImages(int id, List<ImageDto> imagesDto)
        {
            foreach (var i in imagesDto)
            {
                await _context.SaleImage.AddAsync(new SaleImage(){
                    idSale = id,
                    urlImageFireBase = i.UrlImage,
                    nameImageFireBase = i.NameImage
                });   
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<SaleImage>> GetAllImages(int id)
        {
           return await _context.SaleImage.Where(x => x.idSale == id).ToListAsync();
        }

        public async Task DeleteImages(int id)
        {
            var images = await _context.SaleImage.Where(x => x.idSale == id).ToListAsync();
            _context.SaleImage.RemoveRange(images);
            await _context.SaveChangesAsync();
        }
    }
}