using PatifoodDataModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodDataModel 
{
    public class PatifoodDataContext : DbContext
    {
        public Guid ContextId { get; set; }

        public PatifoodDataContext()
            : base("PatifoodDataContext")
        {
            ContextId = Guid.NewGuid();
        }

        public PatifoodDataContext(bool proxyCreationEnabled)
            : this()
        {
            base.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }


        public PatifoodDataContext(bool proxyCreationEnabled, bool readUncommited)
            : this()
        {
            base.Configuration.ProxyCreationEnabled = proxyCreationEnabled;

            if (readUncommited)
                base.Database.ExecuteSqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;");

        }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Packet> Packet { get; set; }
        public DbSet<PacketOrderProduct> PacketOrderProduct { get; set; }
        public DbSet<ProductConfig> ProductConfig { get; set; }
    }
}
