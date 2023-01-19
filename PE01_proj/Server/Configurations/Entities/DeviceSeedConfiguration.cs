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
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new Device
            {
                DeviceID =1,
                DevName = "iPhone 13 Pro Max",
                DevDesc= "256GB",
                DevCost = "$1688",
                DevType = "Phone"
            
            },
            new Device
            {
                DeviceID = 1,
                DevName = "Samsung Galaxy Flip 4",
                DevDesc = "512GB",
                DevCost = "$1255",
                DevType = "Phone"

            }

            );
        }

       
    }
}

