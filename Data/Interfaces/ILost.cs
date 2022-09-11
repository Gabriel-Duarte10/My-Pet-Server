using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Data.Interfaces
{
    public interface ILost
    {
        Task Post(LostRequest model);
        Task PostImages(int id, List<ImageDto> imagesDto);
        Task <List<LostDTO>> GetAll();
        Task <List<LostImage>> GetAllImages(int id);
        Task Put(LostRequest model);
        Task Delete(int id);
        Task DeleteImages(int id);
        Task <LostDTO> GetById(int id);
    }
}