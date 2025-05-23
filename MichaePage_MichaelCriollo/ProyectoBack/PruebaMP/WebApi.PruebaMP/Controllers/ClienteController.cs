using BusinessLogic.PruebaMP.Entity;
using DataAccess.PruebaMP.Interface;
using Entity.PruebaMP.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;

namespace WebApi.PruebaMP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteBL _clienteBL;

        public ClienteController(IUnitOfWork unitOfWork)
        {
            _clienteBL = new ClienteBL(unitOfWork);
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Cliente>> GetAll() 
        {
            try
            {
                var listaClientes = _clienteBL.FindAll();
                return Ok(listaClientes);
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
