using CarRental.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.EFCore.Configurations
{
    
    public class ReservationConfigurations : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
                builder
                .HasOne(r => r.PickupLocation)
                .WithMany(l => l.PickupReservations)
                .HasForeignKey(r => r.PickupLocationId)
                .OnDelete(DeleteBehavior.Restrict);

                builder
                .HasOne(r => r.DropoffLocation)
                .WithMany(l => l.DropoffReservations)
                .HasForeignKey(r => r.DropoffLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(SeedDatas.Reservations);
        }
    }
}
