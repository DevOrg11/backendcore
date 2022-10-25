using Clean.Domain;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;

namespace Clean.Infrastructure;

public class ItemDbContext: DbContext
{
    public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
    {

    }

    public DbSet<Item> Items {get; set;}

}