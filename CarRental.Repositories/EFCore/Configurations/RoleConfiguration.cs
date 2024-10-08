using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.EFCore.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityRole<Guid>
                {
                  Id = Guid.Parse("808f1bfb-06e7-4171-8fd1-cebc54031862"),
                  Name="Basic",
                  NormalizedName="BASIC"
                },
                new IdentityRole<Guid>
                {
                  Id = Guid.Parse("98918782-7e35-4565-8a88-c979ef21e8c6"),
                  Name ="Admin",
                  NormalizedName="ADMIN"
                }
            );
        }
    }
}
