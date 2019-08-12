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
  public class asignacionController : Controller
  {

    private readonly IAsignacionservice _asignacionservice;
    public asignacionController(IAsignacionservice asignacionservice)
    {
      _asignacionservice = asignacionservice;
    }
    // GET: api/asignacion
    [HttpGet]
    public IActionResult Get()
    {
      return Ok(
           _asignacionservice.GetAll()
        );
    }

    // GET: api/asignacion/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
      return Ok(
       _asignacionservice.Get(id)
      );
    }

    // POST: api/asignacion
    [HttpPost]
    public IActionResult Post([FromBody] asignacion model)
    {
      return Ok(
         _asignacionservice.Add(model)
       );

    }

    // PUT: api/asignacion/5
    [HttpPut]
    public IActionResult Put([FromBody] asignacion model)
    {
      return Ok(
         _asignacionservice.Add(model)
       );

    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      return Ok(
        _asignacionservice.Delete(id)
     );

    }
  }
}
