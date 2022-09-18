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
using My_Pet.Services;
using static My_Pet.Data.Dto.Commons;

namespace My_Pet.Controllers
{
    [ApiController]
    [Route("api/rescue")]

    public class RescueControllers: ControllerBase
    {
        private readonly DataContext _context;
        private readonly IRescue _model;
        private readonly ImageService _imagesService;
        public RescueControllers(DataContext context, IRescue model, ImageService imagesService)
        {
             _context = context;
             _model = model;
             _imagesService = imagesService;
        }
        [HttpPost()]
        public async Task<IActionResult> Post(RescueRequest model)
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
            [FromQuery] RescueFilter? filters
        )
        {
            try
            {
                var query = await _model.GetAll();
                if (query == null) return NoContent();
                
                query = query
                .Where(x => filters.species != null ? (x.species == filters.species) : x.id > 0)
                .Where(x => filters.size != null ? (x.size == filters.size) : x.id > 0)
                .Where(x => filters.district != null ? (x.district == filters.district) : x.id > 0)
                .ToList();

                var _pagination = new Pagination<RescueDTO, RescueFilter>();

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
        public async Task<IActionResult> PutById(RescueRequest model)
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
    
        [HttpPost("upload")]
        [RequestSizeLimit(104857600)] // 100MB
        public async Task<ActionResult> UploadImages(int id, List<IFormFile> files)
        {
            var query = await _model.GetById(id);
            if (query == null) return NotFound();
            try
            {
                var imagesDto = await _model.GetAllImages(id);
                if(imagesDto.Count > 0)
                {
                        _imagesService.DeleteImagesFireBase(imagesDto.Select(x => x.nameImageFireBase).ToList());
                        await _model.DeleteImages(id);
                }   
                var newImages = _imagesService.UploadImageFireBase(files).Result;
                await _model.PostImages(id, newImages);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }

            return Ok();
        }
        [HttpGet("images")]
        public async Task<IActionResult> GetImages(int id)
        {
            try
            {   
                var query = await _model.GetAllImages(id);
                if (query == null) return NoContent();

                return Ok(query);
            }
             catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro: {ex.Message}");
            }
        }
    }
}