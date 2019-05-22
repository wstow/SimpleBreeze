using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBreeze.Data

{
    public class OrderContext : DbContext
    {
        public OrderContext()
        {
            //Configuration.ProxyCreationEnabled = false;
            // Configuration.LazyLoadingEnabled = false;
        }

        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
        
        public DbSet<ReqStatus> ReqStatus { get; set; }
    }
}
