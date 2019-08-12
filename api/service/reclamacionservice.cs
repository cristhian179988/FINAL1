using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace service
{
  public interface IReclamacionservice
  {

    IEnumerable<reclamacion> GetAll();
    bool Add(reclamacion model);
    bool Delete(int id);
    bool Update(reclamacion modelo);
    reclamacion Get(int id);
  }
  public class reclamacionservice : IReclamacionservice
  {
    private readonly empleadoDbContext _empleadoDbContext;
    public reclamacionservice(
        empleadoDbContext empleadoDbContext
    )
    {
      _empleadoDbContext = empleadoDbContext;
    }


    public IEnumerable<reclamacion> GetAll()
    {
      var result = new List<reclamacion>();
      try
      {
        result = _empleadoDbContext.reclamacion.ToList();

      }
      catch (System.Exception)
      {

      }
      return result;
    }
    public reclamacion Get(int id)
    {
      var result = new reclamacion();
      try
      {
        result = _empleadoDbContext.reclamacion.Single(x => x.reclamacionId == id);

      }
      catch (System.Exception)
      {

      }
      return result;
    }
    public bool Add(reclamacion model)
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
    public bool Update(reclamacion model)
    {
      try
      {
        var originalModel = _empleadoDbContext.reclamacion.Single(x =>
        x.reclamacionId == model.reclamacionId
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

        _empleadoDbContext.Entry(new reclamacion { reclamacionId = id }).State = EntityState.Deleted; ;
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
