using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Data.Interfaces
{
    public interface IReproduction
    {
        Task Post(ReproductionRequest model);
        Task PostImages(int id, List<ImageDto> imagesDto);
        Task <List<ReproductionDTO>> GetAll();
        Task <List<ReproductionImage>> GetAllImages(int id);
        Task Put(ReproductionRequest model);
        Task Delete(int id);
        Task DeleteImages(int id);
        Task <ReproductionDTO> GetById(int id);
    }
}