using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        public Task<List<SaleDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<SaleDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task Delete(int id)
        {
            _context.Sale.Where(x => x.Id == id).FirstOrDefault().DeleteAt = DateTime.Now;
            
            await _context.SaveChangesAsync();
        }
    }
}