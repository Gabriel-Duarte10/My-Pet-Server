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
    public class AnnouncementRep: IAnnouncement
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public AnnouncementRep(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task Post(AnnouncementRequest model)
        {
            var query = _mapper.Map<Announcement>(model);
            
            query.CreatedAt = DateTime.Now;
            
            await _context.Announcement.AddAsync(query);
            
            await _context.SaveChangesAsync();
        }
        public async Task Put(AnnouncementRequest model)
        {
            var query = _mapper.Map<Announcement>(model);

            query.UpdatedAt = DateTime.Now;

            _context.Announcement.Update(query);

            await _context.SaveChangesAsync();
        }
        public async Task<List<AnnouncementDTO>> GetAll()
        {
           var query = await _context.Announcement.Where(x => x.DeleteAt == null).ToListAsync();
           return _mapper.Map<List<AnnouncementDTO>>(query); 
        }

        public async Task<AnnouncementDTO> GetById(int id)
        {
            var query = await _context.Announcement.Where(x => x.DeleteAt == null && x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<AnnouncementDTO>(query);
        }
        public async Task Delete(int id)
        {
            _context.Announcement.Where(x => x.Id == id).FirstOrDefault().DeleteAt = DateTime.Now;
            
            await _context.SaveChangesAsync();           
        }

        public Task<List<AnnouncementImage>> GetAllImages(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteImages(int id)
        {
            throw new NotImplementedException();
        }

        public Task PostImages(int id, List<ImageDto> imagesDto)
        {
            throw new NotImplementedException();
        }
    }
}