using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System.Collections.Generic;
using System.Linq;

namespace service
{
    public interface IEmpleadoservice
  {
    
    IEnumerable<empleado> GetAll();
    bool Add(empleado model);
    bool Delete(int id);
    bool Update(empleado modelo);
    empleado Get(int id);
  }
  public class empleadoservice : IEmpleadoservice
  {
    private readonly empleadoDbContext _empleadoDbContext;
    public empleadoservice(
        empleadoDbContext empleadoDbContext
    )
    {
      _empleadoDbContext = empleadoDbContext;
    }
  

    public IEnumerable<empleado> GetAll()
    {
      var result = new List<empleado>();
      try
      {
        result = _empleadoDbContext.empleado.ToList();

      }
      catch (System.Exception)
      {
        
      }
      return result;
    }
    public empleado Get(int id)
    {
      var result = new empleado();
      try
      {
        result = _empleadoDbContext.empleado.Single( x => x.empleadoId == id);

      }
      catch (System.Exception)
      {

      }
      return result;
    }
    public bool Add(empleado model)
    {
      try
      {
        _empleadoDbContext.Add(model);
        _empleadoDbContext.SaveChanges();

      }
      catch (System.Exception)
      {
        return false;
      }
      return false;
    }
    public bool Update(empleado model)
    {
      try
      {
        var originalModel = _empleadoDbContext.empleado.Single(x =>
        x.empleadoId == model.empleadoId
        );

        originalModel.Nombre = model.Nombre;
        originalModel.Apellido = model.Apellido;
        originalModel.Bio = model.Bio;

        _empleadoDbContext.Update(originalModel);
        _empleadoDbContext.SaveChanges();

      }
      catch (System.Exception)
      {
        return false;
      }
      return false;
    }
    public bool Delete(int id)
    {
      try
      {
 
        _empleadoDbContext.Entry(new empleado { empleadoId = id }).State = EntityState.Deleted; ;
        _empleadoDbContext.SaveChanges();

      }
      catch (System.Exception)
      {
        return false;
      }
      return false;
    }
  }
}

