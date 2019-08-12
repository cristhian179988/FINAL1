using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testoficina
{
  [TestClass]
  public class UnitTest2
  {
    empleadoDbContext dbContext = new empleadoDbContext(new DbContextOptions<empleadoDbContext>());
    private readonly empleado empleado;

    [TestMethod]
    public void Update()
    {
      var service = new empleadoservice(dbContext);
      var controller = new empleadoController(service);
      var fin = service.Update(empleado);
      Assert.IsNotNull(fin);


    }
  }
}
