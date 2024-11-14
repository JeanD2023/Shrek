using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Custom;
using WebApi.Models;
using WebApi.Models.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly DbpruebaContext _dbpruebaContext;
        public ProductoController(DbpruebaContext dbpruebaContext)
        {
            _dbpruebaContext = dbpruebaContext;
        }

        [HttpGet]
        [Route("Lista")]

        public async Task<ActionResult> Lista()
        {
            var lista = _dbpruebaContext.Productos.ToListAsync();
            return StatusCode(StatusCodes.Status200OK, new {value = lista});
        }
    }
}
