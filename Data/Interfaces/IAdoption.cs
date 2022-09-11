using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Data.Interfaces
{
    public interface IAdoption
    {
        Task Post(AdoptionRequest model);
        Task PostImages(int id, List<ImageDto> imagesDto);
        Task <List<AdoptionDTO>> GetAll();
        Task <List<AdoptionImage>> GetAllImages(int id);
        Task Put(AdoptionRequest model);
        Task Delete(int id);
        Task DeleteImages(int id);
        Task <AdoptionDTO> GetById(int id);   
    }
}