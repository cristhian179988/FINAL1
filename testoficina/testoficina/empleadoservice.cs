using System;

namespace testoficina
{
  internal class empleadoservice
  {
    private empleadoDbContext dbContext;

    public empleadoservice(empleadoDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    internal object Add(empleado empleado, empleado model)
    {
      throw new NotImplementedException();
    }

    internal object Update(empleado empleado)
    {
      throw new NotImplementedException();
    }
  }
}