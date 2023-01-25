using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PE01_proj.Server.Models;
using PE01_proj.Shared.Domain;

namespace PE01_proj.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasData(
            new Customer
            {
                Id = 1,
                CustName = "Jerome Ng ",
                CustAddress = "Blk 91 Ang Mo Kio Ave 3",
                CustEmail = "jeromeyufei54@gmail.com",
                CustContactNo = "98765788",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"


            },
            new Customer
            {
                Id = 2,
                CustName = "Jescrena Chan Yu Ying ",
                CustAddress = "Blk 92 Potong Pasir Ave 1",
                CustEmail = "jescrenachan77@yahoo.com",
                CustContactNo = "98997654",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"

            }

            );
        }


    }
}

