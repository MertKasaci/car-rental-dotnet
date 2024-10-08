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
    public class ModelConfigurations : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.Property(m => m.FuelType)
                 .HasConversion<string>();
            
            builder.Property(m => m.TransmissionType)
                 .HasConversion<string>();

            builder.HasData(SeedDatas.Models);
            
        }
    }
}
