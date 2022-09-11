using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Data.Interfaces
{
    public interface IAnnouncement
    {
        Task Post(AnnouncementRequest model);
        Task PostImages(int id, List<ImageDto> imagesDto);
        Task <List<AnnouncementDTO>> GetAll();
        Task <List<AnnouncementImage>> GetAllImages(int id);
        Task Put(AnnouncementRequest model);
        Task Delete(int id);
        Task DeleteImages(int id);
        Task <AnnouncementDTO> GetById(int id);
    }
}