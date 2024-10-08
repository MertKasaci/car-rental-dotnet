using CarRental.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.EFCore.Configurations
{
    public class BrandConfigurations : IEntityTypeConfiguration<Brand>
    {
        
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(SeedDatas.Brands);
        }
    }
}
