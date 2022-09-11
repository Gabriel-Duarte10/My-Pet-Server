using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Data.Interfaces
{
    public interface IRescue
    {
        Task Post(RescueRequest model);
        Task PostImages(int id, List<ImageDto> imagesDto);
        Task <List<RescueDTO>> GetAll();
        Task <List<RescueImage>> GetAllImages(int id);
        Task Put(RescueRequest model);
        Task Delete(int id);
        Task DeleteImages(int id);
        Task <RescueDTO> GetById(int id);
    }
}