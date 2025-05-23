using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using BusinessLogic.PruebaMP.Entity;
using DataAccess.PruebaMP.Interface;
using Entity.PruebaMP.Entities;
using System.Net;

namespace WebApi.PruebaMP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoBL _productoBL;

        public ProductoController(IUnitOfWork unitOfWork)
        {
            _productoBL = new ProductoBL(unitOfWork);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] Producto producto)
        {
            try
            {
                _productoBL.Create(producto); 
                return Ok("Producto creado exitosamente.");
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        private ObjectResult HandleException(Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
        }
    }
}
