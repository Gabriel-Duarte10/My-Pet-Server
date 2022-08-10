using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;

namespace My_Pet.Data.Interfaces
{
    public interface IAdoption
    {
        Task Post(AdoptionRequest model);
        Task <List<AdoptionDTO>> GetAll();
        Task Put(AdoptionRequest model);
        Task Delete(int id);
        Task <AdoptionDTO> GetById(int id);   
    }
}