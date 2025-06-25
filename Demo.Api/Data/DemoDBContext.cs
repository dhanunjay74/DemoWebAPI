using Demo.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Api.Data
{
    public class DemoDBContext : DbContext
    {
        public DemoDBContext(DbContextOptions dbContextOptions):base(dbContextOptions) 
        {
            
        }
        public DbSet<Product> Products { get; set; }
        
    }
}
