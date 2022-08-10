using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;

namespace My_Pet.Data.Interfaces
{
    public interface ISale
    {
        Task Post(SaleRequest model);
        Task <List<SaleDTO>> GetAll();
        Task Put(SaleRequest model);
        Task Delete(int id);
        Task <SaleDTO> GetById(int id);
    }
}