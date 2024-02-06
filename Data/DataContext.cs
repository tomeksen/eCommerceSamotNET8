using eCommerceSamotNet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommerceSamotNet8.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Users> users { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<OrderLines> orderLines { get; set; }
        public DbSet<DeliveryAddress> deliveryAddress { get; set; }

    }
}
