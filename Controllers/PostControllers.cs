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
                var user =  await _context.User.AddAsync(new Models.User(){
                    name = "Gabriel Silva Duarte",
                    email = "gabriel.silvaduarte@hotmail.com",
                    phone = "21965116166",
                    password = "08162905",
                    type = Models.TypeLogin.CreateUser
                });
                await _context.SaveChangesAsync();
                for (int i = 1; i <= 10; i++)
                {
                    await _context.Adoption.AddAsync(new Models.Adoption(){
                        name = "Pet Adoption " + i,
                        genre = "Macho Adoption " + i,
                        breed = "Raça Adoption " + i,
                        size = "Tamanho Adoption " + i,
                        monthBirth = 1,
                        yearBirth = 2000 + i,
                        district = "Bairro Adoption " + i,
                        description = "Descrição Adoption " + i,
                        species = "Especie " + 1,
                        userId = user.Entity.Id
                    });
                    await _context.Lost.AddAsync(new Models.Lost(){
                        name = "Pet Lost " + i,
                        genre = "Macho Lost " + i,
                        breed = "Raça Lost " + i,
                        size = "Tamanho Lost " + i,
                        monthBirth = 2,
                        yearBirth = 2000 + i,
                        district = "Bairro Lost " + i,
                        description = "Descrição Lost " + i,
                        species = "Especie " + 1,
                        userId = user.Entity.Id
                    });
                    await _context.Reproduction.AddAsync(new Models.Reproduction(){
                        name = "Pet reproduction " + i,
                        genre = "Macho reproduction " + i,
                        breed = "Raça reproduction " + i,
                        size = "Tamanho reproduction " + i,
                        monthBirth = 2,
                        yearBirth = 2000 + i,
                        district = "Bairro reproduction " + i,
                        description = "Descrição reproduction " + i,
                        species = "Especie " + 1,
                        userId = user.Entity.Id
                    });
                    await _context.Rescue.AddAsync(new Models.Rescue(){
                        size = "Tamanho rescue " + i,
                        district = "Bairro rescue " + i,
                        road = "Rua Rescue " + i,
                        description = "Descrição rescue " + i,
                        species = "Especie " + 1,
                        userId = user.Entity.Id
                    });
                    await _context.Sale.AddAsync(new Models.Sale(){
                        name = "Pet Sale " + i,
                        genre = "Macho Sale " + i,
                        breed = "Raça Sale " + i,
                        size = "Tamanho Sale " + i,
                        price = 1000.00 + i * 500,
                        monthBirth = 1,
                        yearBirth = 2000 + i,
                        district = "Bairro Sale " + i,
                        description = "Descrição Sale " + i,
                        species = "Especie " + 1,
                        userId = user.Entity.Id
                    });
                    await _context.Announcement.AddAsync(new Models.Announcement(){
                        name = "Anuncio " + i,
                        phoneAnno = "Telefone " + i,
                        emailAnno = "Email " + i,
                        districAnno = "Bairro " + i,
                        description = "Descrição " + i,
                        userId = user.Entity.Id
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