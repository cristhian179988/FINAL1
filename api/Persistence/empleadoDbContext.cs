using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
  public class empleadoDbContext : DbContext
  {
     public DbSet<empleado> empleado { get; set; }
    public DbSet<departamento> departamento { get; set; }
    public DbSet<asignacion> asignacion { get; set; }
    public DbSet<reclamacion> reclamacion { get; set; }

    public empleadoDbContext(DbContextOptions<empleadoDbContext> options)
      : base(options)
    { }
  }
}
