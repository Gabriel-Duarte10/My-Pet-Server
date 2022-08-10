using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;

namespace My_Pet.Data.Interfaces
{
    public interface ILost
    {
        Task Post(LostRequest model);
        Task <List<LostDTO>> GetAll();
        Task Put(LostRequest model);
        Task Delete(int id);
        Task <LostDTO> GetById(int id);
    }
}