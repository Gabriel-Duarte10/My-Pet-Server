using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Data.Interfaces
{
    public interface ISale
    {
        Task Post(SaleRequest model);
        Task PostImages(int id, List<ImageDto> imagesDto);
        Task <List<SaleDTO>> GetAll();
        Task <List<SaleImage>> GetAllImages(int id);
        Task Put(SaleRequest model);
        Task Delete(int id);
        Task DeleteImages(int id);
        Task <SaleDTO> GetById(int id);
    }
}