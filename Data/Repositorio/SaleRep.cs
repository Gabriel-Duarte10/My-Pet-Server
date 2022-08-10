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

            await _context.Sale.AddAsync(query);
            
            await _context.SaveChangesAsync();
        }
        public Task Put(SaleRequest model)
        {
            throw new NotImplementedException();
        }
        public Task<List<SaleDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<SaleDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}