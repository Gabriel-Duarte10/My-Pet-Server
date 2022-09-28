using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using My_Pet.Data.Context;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/user")]
    public class UserControllers : ControllerBase
    {
        private readonly ILogger<UserControllers> _logger;
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserControllers(DataContext context, IMapper mapper, ILogger<UserControllers> logger)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("google")]
        public async Task<IActionResult> GoogleLogin()
        {
            try
            {   
               var name = User.Claims.Where(x => x.Type == "name").FirstOrDefault().Value;
               var email = User.Claims.Where(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").FirstOrDefault().Value;

               var query = _context.User.Where(x => x.email == email).FirstOrDefault();
                if(query != null)
                {
                    return Ok(_mapper.Map<UserDTO>(query));
                }
                else{
                    var user = await _context.User.AddAsync(new User(){
                        email = email,
                        name = name,
                        CreatedAt = DateTime.Now,
                        type = TypeLogin.Google,
                    });

                    await _context.SaveChangesAsync();
                    
                    return Ok(_mapper.Map<UserDTO>(_context.User.Where(x => x.Id == user.Entity.Id).FirstOrDefault()));
                }
            }
             catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro: {ex.Message}");
            }
        }
        [HttpPost("phone")]
        [AllowAnonymous]
        public async Task<IActionResult> TelefoneByIdByUser(UserRequest userPhone)
        {
            try
            {   
               var query = _context.User.Where(x => x.Id == userPhone.id).FirstOrDefault();
                if(query == null)
                {
                    return NotFound();
                }
                else{
                    
                    query.phone = userPhone.phone;
                    await _context.SaveChangesAsync();

                    return Ok(_mapper.Map<UserDTO>(query));
                }
            }
             catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro: {ex.Message}");
            }
        }
       
    }
}