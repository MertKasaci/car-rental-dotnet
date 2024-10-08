using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.EFCore
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();

            builder.HasData(
                new User
                {
                  FirstName = "Mert",
                  LastName = "Kasaci",
                  Id = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb9"),
                  UserName = "mertkasaci",
                  NormalizedUserName="MERTKASACI",
                  Email = "mertkasacidev@gmail.com",
                  NormalizedEmail = "MERTKASACIDEV@GMAIL.COM",
                  PhoneNumber = "1234567890",
                  Gender = Gender.Male,
                  PasswordHash = hasher.HashPassword(null, "anka12"),
                  LockoutEnabled = false,
                  SecurityStamp = Guid.NewGuid().ToString()
                },
                new User
                {
                  FirstName = "Serkan",
                  LastName = "Demir",
                  Id = Guid.Parse("5e88594b-46ae-4dd7-b7c1-c89b9dcd976b"),
                  UserName = "serkandemir",
                  NormalizedUserName="SERKANDEMIR",
                  Email = "serkandemirdev@gmail.com",
                  NormalizedEmail = "SERKANDEMIRDEV@GMAIL.COM",
                  PhoneNumber = "312312313",
                  Gender = Gender.Male,
                  PasswordHash = hasher.HashPassword(null, "naka12"),
                  LockoutEnabled = false,
                  SecurityStamp = Guid.NewGuid().ToString()
                },
                new User
                {
                  FirstName = "Dilsat",
                  LastName = "Kisabacak",
                  Id = Guid.Parse("6a869c2b-19ef-4435-a131-f9c894db7d75"),
                  UserName = "dilsatkisabacak",
                  NormalizedUserName="DILSATKISABACAK",
                  Email = "dilsatkisabacakdev@gmail.com",
                  NormalizedEmail = "DILSATKISABACAKDEV@GMAIL.COM",
                  PhoneNumber = "78678678",
                  Gender = Gender.Male,
                  PasswordHash = hasher.HashPassword(null, "akan12"),
                  LockoutEnabled = false,
                  SecurityStamp = Guid.NewGuid().ToString()
                },
                new User
                {
                    FirstName = "Ahmet",
                    LastName = "Yilmaz",
                    Id = Guid.Parse("d7a8f5c2-09f3-47b3-afe2-4730d0473c8b"),
                    UserName = "ahmetyilmaz",
                    NormalizedUserName = "AHMETYILMAZ",
                    Email = "ahmetyilmazdev@gmail.com",
                    NormalizedEmail = "AHMETYILMAZDEV@GMAIL.COM",
                    PhoneNumber = "5432198765",
                    Gender = Gender.Male,
                    PasswordHash = hasher.HashPassword(null, "zxcvbn123"),
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new User
                {
                   FirstName = "Elif",
                   LastName = "Kara",
                   Id = Guid.Parse("e3bfb9e0-2c44-4fd2-8f9e-5c49a0c9c4f1"),
                   UserName = "elifkara",
                   NormalizedUserName = "ELIFKARA",
                   Email = "elifkaradev@gmail.com",
                   NormalizedEmail = "ELIFKARADEV@GMAIL.COM",
                   PhoneNumber = "6789456123",
                   Gender = Gender.Female,
                   PasswordHash = hasher.HashPassword(null, "qwerty123"),
                   LockoutEnabled = false,
                   SecurityStamp = Guid.NewGuid().ToString()
                }

                );
        }
    }
}
