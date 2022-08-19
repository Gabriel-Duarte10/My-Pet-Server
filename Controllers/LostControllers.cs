using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Pet.Data.Context;
using My_Pet.Data.Dto;
using My_Pet.Data.Interfaces;
using My_Pet.Data.Requests;
using static My_Pet.Data.Dto.Commons;

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
        public async Task<IActionResult> GetAll(
            [FromQuery] int page, 
            [FromQuery] int perPage,
            [FromQuery] LostFilter? filters
        )
        {
            try
            {
                var query = await _model.GetAll();
                if (query == null) return NoContent();
                
                query = query
                .Where(x => filters.species != null ? (x.species == filters.species) : x.id > 0)
                .Where(x => filters.genre != null ? (x.genre == filters.genre) : x.id > 0)
                .Where(x => filters.breed != null ? (x.breed == filters.breed) : x.id > 0)
                .Where(x => filters.size != null ? (x.size == filters.size) : x.id > 0)
                .Where(x => filters.ageMin != null ? ((DateTime.Now.Year - x.yearBirth) >= filters.ageMin) : x.id > 0)
                .Where(x => filters.ageMax != null ? ((DateTime.Now.Year - x.yearBirth) <= filters.ageMax) : x.id > 0)
                .Where(x => filters.district != null ? (x.district == filters.district) : x.id > 0)
                .ToList();

                var _pagination = new Pagination<LostDTO, LostFilter>();

                _pagination.Page = page;
                _pagination.PerPage = perPage;
                _pagination.TotalItems = query.Count();
                _pagination.TotalPages = (int)Math.Ceiling((double)query.Count()/perPage);
                
                _pagination.Data = query.Skip(((page-1)*perPage)).Take(perPage).ToList();

                return Ok(_pagination);

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