using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Pet.Data.Context;
using My_Pet.Data.Interfaces;
using My_Pet.Data.Requests;

namespace My_Pet.Controllers
{
    [ApiController]
    [Route("api/lost")]
    public class LostControllers: ControllerBase
    {
        private readonly DataContext _context;
        private readonly ILost _model;
        public LostControllers(DataContext context, ILost model)
        {
             _context = context;
             _model = model;
        }
        [HttpPost()]
        public async Task<IActionResult> Post(LostRequest model)
        {
            try
            {
                await _model.Post(model);
            
                return Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro: {ex.Message}");
            }
        }
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = await _model.GetAll();
                if (query == null) return NoContent();
            
                return Ok(query);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro: {ex.Message}");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {   
                var query = await _model.GetById(id);
                if (query == null) return NoContent();

                return Ok(query);
            }
             catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro: {ex.Message}");
            }
        }
        [HttpPut()]
        public async Task<IActionResult> PutById(LostRequest model)
        {
            try
            {
                
                await _model.Put(model);
                
                return Ok();
            }
           catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro: {ex.Message}");
            }   
        }
        [HttpDelete()]
        public async Task<IActionResult> DeleteById(int id)
        {
            try
            {
                await _model.Delete(id);     
              
                return Ok();

            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro: {ex.Message}");
            }
        }
    }
}