using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PE01_proj.Server.Configurations.Entities;
using PE01_proj.Server.Models;
using PE01_proj.Shared.Domain;

namespace PE01_proj.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<TradeDev> TradeDevs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new DeviceSeedConfiguration());
          
        }
    }
}
