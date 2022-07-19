using Microsoft.EntityFrameworkCore;

namespace HardwareShop.Api.Data
{
    public class HardwareShopDbContext:DbContext
    {
        public HardwareShopDbContext(DbContextOptions<HardwareShopDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
