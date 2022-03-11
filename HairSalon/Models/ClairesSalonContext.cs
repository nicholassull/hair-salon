using Microsoft.EntityFrameworkCore;
namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    //Change to class the DB is dealing with
    public DbSet<Item> Items { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}