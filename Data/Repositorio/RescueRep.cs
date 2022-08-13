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
        public Task<List<RescueDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<RescueDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task Delete(int id)
        {
            _context.Rescue.Where(x => x.Id == id).FirstOrDefault().DeleteAt = DateTime.Now;
            
            await _context.SaveChangesAsync();
        }
    }
}