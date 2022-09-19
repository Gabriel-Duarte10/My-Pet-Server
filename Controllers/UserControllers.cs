using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace My_Pet.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserControllers : ControllerBase
    {
        private readonly ILogger<UserControllers> _logger;

        public UserControllers(ILogger<UserControllers> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        [Authorize]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {   
               var name = User.Claims.Where(x => x.Type == "name").FirstOrDefault().Value;
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