using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using service;

namespace api.Controllers
{
    [Route ("[controller]")]
    public class empleadosController : Controller
    {

    private readonly IEmpleadoservice _empleadoservice;
    public empleadosController(IEmpleadoservice empleadoservice)
    {
      _empleadoservice = empleadoservice;
    }
        // GET: api/empleados
        [HttpGet]
        public IActionResult Get()
        {
          return Ok(
               _empleadoservice.GetAll()
            );
        }

        // GET: api/empleados/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           return Ok(
            _empleadoservice.Get(id)
           );
    }

        // POST: api/empleados
        [HttpPost]
        public IActionResult Post([FromBody] empleado model)
        {
            return Ok(
               _empleadoservice.Add(model)
             );

    }

    // PUT: api/empleados/5
    [HttpPut]
    public IActionResult Put([FromBody] empleado model)
    {
      return Ok(
         _empleadoservice.Add(model)
       );

    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           return Ok(
             _empleadoservice.Delete(id)
          );

    }
  }
}
