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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityUserRole<Guid>
                {
                  RoleId = Guid.Parse("808f1bfb-06e7-4171-8fd1-cebc54031862"),
                  UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb9"),  
                },
                new IdentityUserRole<Guid>
                {
                  RoleId = Guid.Parse("808f1bfb-06e7-4171-8fd1-cebc54031862"),
                  UserId = Guid.Parse("5e88594b-46ae-4dd7-b7c1-c89b9dcd976b"),  
                },
                new IdentityUserRole<Guid>
                {
                  RoleId = Guid.Parse("808f1bfb-06e7-4171-8fd1-cebc54031862"),
                  UserId = Guid.Parse("6a869c2b-19ef-4435-a131-f9c894db7d75"),  
                },
                new IdentityUserRole<Guid>
                {
                  RoleId = Guid.Parse("808f1bfb-06e7-4171-8fd1-cebc54031862"),
                  UserId = Guid.Parse("d7a8f5c2-09f3-47b3-afe2-4730d0473c8b"),  
                },
                new IdentityUserRole<Guid>
                {
                  RoleId = Guid.Parse("808f1bfb-06e7-4171-8fd1-cebc54031862"),
                  UserId = Guid.Parse("e3bfb9e0-2c44-4fd2-8f9e-5c49a0c9c4f1"),  
                }
            
            );
        }
    }
}
