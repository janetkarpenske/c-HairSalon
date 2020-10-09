
using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class SalonContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public SalonContext(DbContextOptions options) : base(options) { }
  }
}