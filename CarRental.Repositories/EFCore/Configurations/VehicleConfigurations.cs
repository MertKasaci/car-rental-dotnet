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
    public class VehicleConfigurations : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.Property(v => v.Status)
                .HasConversion<string>();

            builder.Property(v => v.Color)
                .HasConversion<string>();

            builder.HasData(SeedDatas.Vehicles);
        }
    }
}
