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
  [Route("[controller]")]
  public class departamentoController : Controller
  {

    private readonly IDepartamentoservice _departamentoservice;
    public departamentoController(IDepartamentoservice departamentoservice)
    {
      _departamentoservice = departamentoservice;
    }
    // GET: api/departamento
    [HttpGet]
    public IActionResult Get()
    {
      return Ok(
           _departamentoservice.GetAll()
        );
    }

    // GET: api/departamento/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
      return Ok(
       _departamentoservice.Get(id)
      );
    }

    // POST: api/departamento
    [HttpPost]
    public IActionResult Post([FromBody] departamento model)
    {
      return Ok(
         _departamentoservice.Add(model)
       );

    }

    // PUT: api/empleados/5
    [HttpPut]
    public IActionResult Put([FromBody] departamento model)
    {
      return Ok(
         _departamentoservice.Add(model)
       );

    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      return Ok(
        _departamentoservice.Delete(id)
     );

    }
  }
}
