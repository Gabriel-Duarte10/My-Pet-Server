using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;

namespace My_Pet.Data.Interfaces
{
    public interface IReproduction
    {
        Task Post(ReproductionRequest model);
        Task <List<ReproductionDTO>> GetAll();
        Task Put(ReproductionRequest model);
        Task Delete(int id);
        Task <ReproductionDTO> GetById(int id);
    }
}