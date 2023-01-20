using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PE01_proj.Server.Models;
using PE01_proj.Shared.Domain;

namespace PE01_proj.Server.Configurations.Entities
{
    public class DeviceSeedConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
           
            builder.HasData(
            new Device
            {
                Id =1,
                DevName = "iPhone 13 Pro Max",
                DevDesc= "256GB",
                DevCost = "$1688",
                DevType = "Phone",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"

            },
            new Device
            {
                Id = 2,
                DevName = "Samsung Galaxy Flip 4",
                DevDesc = "512GB",
                DevCost = "$1255",
                DevType = "Phone",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"

            }

            );
        }

       
    }
}

