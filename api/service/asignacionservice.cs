using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace service
{
  public interface IAsignacionservice
  {

    IEnumerable<asignacion> GetAll();
    bool Add(asignacion model);
    bool Delete(int id);
    bool Update(asignacion modelo);
    asignacion Get(int id);
  }
  public class asignacionservice : IAsignacionservice
  {
    private readonly empleadoDbContext _empleadoDbContext;
    public asignacionservice(
        empleadoDbContext empleadoDbContext
    )
    {
      _empleadoDbContext = empleadoDbContext;
    }


    public IEnumerable<asignacion> GetAll()
    {
      var result = new List<asignacion>();
      try
      {
        result = _empleadoDbContext.asignacion.ToList();

      }
      catch (System.Exception)
      {

      }
      return result;
    }
    public asignacion Get(int id)
    {
      var result = new asignacion();
      try
      {
        result = _empleadoDbContext.asignacion.Single(x => x.asignacionId == id);

      }
      catch (System.Exception)
      {

      }
      return result;
    }
    public bool Add(asignacion model)
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
    public bool Update(asignacion model)
    {
      try
      {
        var originalModel = _empleadoDbContext.asignacion.Single(x =>
        x.asignacionId == model.asignacionId
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

        _empleadoDbContext.Entry(new asignacion { asignacionId = id }).State = EntityState.Deleted; ;
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

