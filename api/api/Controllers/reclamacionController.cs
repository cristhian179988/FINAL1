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
  public class reclamacionController : Controller
  {

    private readonly IReclamacionservice _reclamacionservice;
    public reclamacionController(IReclamacionservice reclamacionservice)
    {
      _reclamacionservice = reclamacionservice;
    }
    // GET: api/empleados
    [HttpGet]
    public IActionResult Get()
    {
      return Ok(
           _reclamacionservice.GetAll()
        );
    }

    // GET: api/empleados/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
      return Ok(
       _reclamacionservice.Get(id)
      );
    }

    // POST: api/empleados
    [HttpPost]
    public IActionResult Post([FromBody] reclamacion model)
    {
      return Ok(
         _reclamacionservice.Add(model)
       );

    }

    // PUT: api/empleados/5
    [HttpPut]
    public IActionResult Put([FromBody] reclamacion model)
    {
      return Ok(
         _reclamacionservice.Add(model)
       );

    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      return Ok(
        _reclamacionservice.Delete(id)
     );

    }
  }
}
