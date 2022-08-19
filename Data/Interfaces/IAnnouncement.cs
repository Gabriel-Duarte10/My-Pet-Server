using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;

namespace My_Pet.Data.Interfaces
{
    public interface IAnnouncement
    {
        Task Post(AnnouncementRequest model);
        Task <List<AnnouncementDTO>> GetAll();
        Task Put(AnnouncementRequest model);
        Task Delete(int id);
        Task <AnnouncementDTO> GetById(int id);
    }
}