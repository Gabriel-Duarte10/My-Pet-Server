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
        public Task<List<AdoptionDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AdoptionDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task Delete(int id)
        {
            _context.Adoption.Where(x => x.Id == id).FirstOrDefault().DeleteAt = DateTime.Now;
            
            await _context.SaveChangesAsync();           
        }
    }
}