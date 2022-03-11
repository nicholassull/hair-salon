using Microsoft.EntityFrameworkCore;
namespace ClairesSalon.Models
{
  public class ClairesSalonContext : DbContext
  {
    //Change to class the DB is dealing with
    public DbSet<Item> Items { get; set; }
    public ClairesSalonrContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}