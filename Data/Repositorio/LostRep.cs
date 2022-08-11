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
    public class LostRep : ILost
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public LostRep(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task Post(LostRequest model)
        {
            var query = _mapper.Map<Lost>(model);

            query.CreatedAt = DateTime.Now;

            await _context.Lost.AddAsync(query);
            
            await _context.SaveChangesAsync();
        }
        public Task Put(LostRequest model)
        {
            throw new NotImplementedException();
        }
        public Task<List<LostDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<LostDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}