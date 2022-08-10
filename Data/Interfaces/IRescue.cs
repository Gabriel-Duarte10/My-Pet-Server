using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;

namespace My_Pet.Data.Interfaces
{
    public interface IRescue
    {
        Task Post(RescueRequest model);
        Task <List<RescueDTO>> GetAll();
        Task Put(RescueRequest model);
        Task Delete(int id);
        Task <RescueDTO> GetById(int id);
    }
}