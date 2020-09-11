using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly MeuDbContext context;
        public ClienteController(MeuDbContext context)
        {
            this.context = context;
        }
        [HttpGet("cadastrar")]
        public IActionResult Index()
        {
            var cliente = new Cliente()
            {
                Nome = "Paulo Barbosa",
                Email = "paulohjbarbosa@gmail.com",
                DataCadastro = DateTime.UtcNow
            };

            /* TROCAR E COLOCAR NO REPOSITORY */
            context.Clientes.Add(cliente);
            context.SaveChanges();

            return Ok();
        }
    }
}
