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

            await _context.Reproduction.AddAsync(query);
            
            await _context.SaveChangesAsync();
        }
        public Task Put(ReproductionRequest model)
        {
            throw new NotImplementedException();
        }
        public Task<List<ReproductionDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ReproductionDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}