using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Pet.Data.Context;
using My_Pet.Data.Interfaces;

namespace My_Pet.Controllers
{
    [ApiController]
    [Route("api/post")]
    public class PostControllers: ControllerBase
    {
        private readonly DataContext _context;
        public PostControllers(DataContext context)
        {
             _context = context;
        }
        [HttpPost()]
        public async Task<IActionResult> Post()
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    await _context.Adoption.AddAsync(new Models.Adoption(){
                        namePet = "Pet Adoption " + i,
                        genre = "Macho Adoption " + i,
                        breed = "Raça Adoption " + i,
                        size = "Tamanho Adoption " + i,
                        monthBirth = 1,
                        yearBirth = 2000 + i,
                        district = "Bairro Adoption " + i,
                        description = "Descrição Adoption " + i
                    });
                    await _context.Lost.AddAsync(new Models.Lost(){
                        namePet = "Pet Lost " + i,
                        genre = "Macho Lost " + i,
                        breed = "Raça Lost " + i,
                        size = "Tamanho Lost " + i,
                        monthBirth = 2,
                        yearBirth = 2000 + i,
                        district = "Bairro Lost " + i,
                        description = "Descrição Lost " + i
                    });
                    await _context.Reproduction.AddAsync(new Models.Reproduction(){
                        namePet = "Pet reproduction " + i,
                        genre = "Macho reproduction " + i,
                        breed = "Raça reproduction " + i,
                        size = "Tamanho reproduction " + i,
                        monthBirth = 2,
                        yearBirth = 2000 + i,
                        district = "Bairro reproduction " + i,
                        description = "Descrição reproduction " + i
                    });
                    await _context.Rescue.AddAsync(new Models.Rescue(){
                        size = "Tamanho rescue " + i,
                        district = "Bairro rescue " + i,
                        road = "Rua Rescue " + i,
                        description = "Descrição rescue " + i
                    });
                    await _context.Sale.AddAsync(new Models.Sale(){
                        namePet = "Pet Sale " + i,
                        genre = "Macho Sale " + i,
                        breed = "Raça Sale " + i,
                        size = "Tamanho Sale " + i,
                        price = 1000.00 + i * 500,
                        monthBirth = 1,
                        yearBirth = 2000 + i,
                        district = "Bairro Sale " + i,
                        description = "Descrição Sale " + i
                    });
                    await _context.Announcement.AddAsync(new Models.Announcement(){
                        nameAnno = "Anuncio " + i,
                        phoneAnno = "Telefone " + i,
                        emailAnno = "Email " + i,
                        districAnno = "Bairro " + i,
                        description = "Descrição " + i
                    });
                    await _context.SaveChangesAsync();
                }
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