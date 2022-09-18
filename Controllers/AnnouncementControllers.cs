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
    [Route("api/announcement")]
    public class AnnouncementControllers: ControllerBase
    {
        private readonly DataContext _context;
        private readonly IAnnouncement _model;
        private readonly ImageService _imagesService;
        public AnnouncementControllers(DataContext context, IAnnouncement model, ImageService imagesService)
        {
             _context = context;
             _model = model;
             _imagesService = imagesService;
        }
        [HttpPost()]
        public async Task<IActionResult> Post(AnnouncementRequest model)
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
            [FromQuery] int perPage
        )
        {
            try
            {
                var query = await _model.GetAll();
                if (query == null) return NoContent();

                var _pagination = new Pagination<AnnouncementDTO, string>();

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
        public async Task<IActionResult> PutById(AnnouncementRequest model)
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