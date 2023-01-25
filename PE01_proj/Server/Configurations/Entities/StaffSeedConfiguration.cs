using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PE01_proj.Server.Models;
using PE01_proj.Shared.Domain;

namespace PE01_proj.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {

            builder.HasData(
            new Staff
            {
                Id = 1,
                StaffName = "John Tan",
                StaffAddress = "Blk 53 Marsiling Road",
                StaffPosition = "Manager",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"

            },
            new Staff
            {


                Id = 2,
                StaffName = "Mei Yan",
                StaffAddress = "Blk 143 Bedok North",
                StaffPosition = "Sale Associate",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"

            }

            );
        }


    }
}

