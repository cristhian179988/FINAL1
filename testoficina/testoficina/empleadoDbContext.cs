namespace testoficina
{
  internal class empleadoDbContext
  {
    private DbContextOptions<empleadoDbContext> dbContextOptions;

    public empleadoDbContext(DbContextOptions<empleadoDbContext> dbContextOptions)
    {
      this.dbContextOptions = dbContextOptions;
    }
  }
}