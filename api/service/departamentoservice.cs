using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace service
{
  public interface IDepartamentoservice
  {

    IEnumerable<departamento> GetAll();
    bool Add(departamento model);
    bool Delete(int id);
    bool Update(departamento modelo);
    departamento Get(int id);
  }
  public class departamentoservice : IDepartamentoservice
  {
    private readonly empleadoDbContext _empleadoDbContext;
    public departamentoservice(
        empleadoDbContext empleadoDbContext
    )
    {
      _empleadoDbContext = empleadoDbContext;
    }


    public IEnumerable<departamento> GetAll()
    {
      var result = new List<departamento>();
      try
      {
        result = _empleadoDbContext.departamento.ToList();

      }
      catch (System.Exception)
      {

      }
      return result;
    }
    public departamento Get(int id)
    {
      var result = new departamento();
      try
      {
        result = _empleadoDbContext.departamento.Single(x => x.departamentoId == id);

      }
      catch (System.Exception)
      {

      }
      return result;
    }
    public bool Add(departamento model)
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
    public bool Update(departamento model)
    {
      try
      {
        var originalModel = _empleadoDbContext.departamento.Single(x =>
        x.departamentoId == model.departamentoId
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

        _empleadoDbContext.Entry(new departamento { departamentoId = id }).State = EntityState.Deleted; ;
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
