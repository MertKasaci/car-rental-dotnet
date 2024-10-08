using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class SeedDatas
{
    public static readonly Brand[] Brands = new Brand[]
    {
        new Brand { Id = Guid.NewGuid(), Name = "Toyota" },
        new Brand { Id = Guid.NewGuid(), Name = "Honda" },
        new Brand { Id = Guid.NewGuid(), Name = "Ford" },
        new Brand { Id = Guid.NewGuid(), Name = "Chevrolet" },
        new Brand { Id = Guid.NewGuid(), Name = "BMW" },
        new Brand { Id = Guid.NewGuid(), Name = "Mercedes-Benz" },
        new Brand { Id = Guid.NewGuid(), Name = "Volkswagen" },
        new Brand { Id = Guid.NewGuid(), Name = "Audi" },
        new Brand { Id = Guid.NewGuid(), Name = "Hyundai" },
        new Brand { Id = Guid.NewGuid(), Name = "Nissan" }
    };

    public static readonly Model[] Models = new Model[]
    {
        new Model { Id = Guid.NewGuid(), Name = "Corolla", BrandId = Brands[0].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 2, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Civic", BrandId = Brands[1].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 2, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Focus", BrandId = Brands[2].Id, Capacity = 5, FuelType = FuelType.Diesel, LuggageCapacity = 3, TransmissionType = TransmissionType.Manual },
        new Model { Id = Guid.NewGuid(), Name = "Malibu", BrandId = Brands[3].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 2, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "3 Series", BrandId = Brands[4].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 3, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "C-Class", BrandId = Brands[5].Id, Capacity = 5, FuelType = FuelType.Diesel, LuggageCapacity = 3, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Passat", BrandId = Brands[6].Id, Capacity = 5, FuelType = FuelType.Diesel, LuggageCapacity = 3, TransmissionType = TransmissionType.Manual },
        new Model { Id = Guid.NewGuid(), Name = "A4", BrandId = Brands[7].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 2, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Elantra", BrandId = Brands[8].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 2, TransmissionType = TransmissionType.Manual },
        new Model { Id = Guid.NewGuid(), Name = "Altima", BrandId = Brands[9].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 3, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Camry", BrandId = Brands[0].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 2, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Accord", BrandId = Brands[1].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 3, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Mustang", BrandId = Brands[2].Id, Capacity = 4, FuelType = FuelType.Petrol, LuggageCapacity = 2, TransmissionType = TransmissionType.Manual },
        new Model { Id = Guid.NewGuid(), Name = "Impala", BrandId = Brands[3].Id, Capacity = 5, FuelType = FuelType.Diesel, LuggageCapacity = 3, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "X5", BrandId = Brands[4].Id, Capacity = 5, FuelType = FuelType.Diesel, LuggageCapacity = 4, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "E-Class", BrandId = Brands[5].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 3, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Tiguan", BrandId = Brands[6].Id, Capacity = 5, FuelType = FuelType.Diesel, LuggageCapacity = 3, TransmissionType = TransmissionType.Manual },
        new Model { Id = Guid.NewGuid(), Name = "Q5", BrandId = Brands[7].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 2, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Sonata", BrandId = Brands[8].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 3, TransmissionType = TransmissionType.Automatic },
        new Model { Id = Guid.NewGuid(), Name = "Maxima", BrandId = Brands[9].Id, Capacity = 5, FuelType = FuelType.Petrol, LuggageCapacity = 3, TransmissionType = TransmissionType.Automatic }
    };

    public static readonly Vehicle[] Vehicles = new Vehicle[]
    {
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[0].Id, Year = 2020, Color = VehicleColor.Red, DailyPrice = 50, Status = VehicleStatus.Available, LicensePlate = "ABC123" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[1].Id, Year = 2019, Color = VehicleColor.Blue, DailyPrice = 60, Status = VehicleStatus.Available, LicensePlate = "DEF456" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[2].Id, Year = 2021, Color = VehicleColor.Green, DailyPrice = 55, Status = VehicleStatus.Available, LicensePlate = "GHI789" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[3].Id, Year = 2018, Color = VehicleColor.Black, DailyPrice = 70, Status = VehicleStatus.Available, LicensePlate = "JKL012" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[4].Id, Year = 2022, Color = VehicleColor.White, DailyPrice = 80, Status = VehicleStatus.Available, LicensePlate = "MNO345" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[5].Id, Year = 2020, Color = VehicleColor.Red, DailyPrice = 90, Status = VehicleStatus.Available, LicensePlate = "PQR678" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[6].Id, Year = 2019, Color = VehicleColor.Blue, DailyPrice = 85, Status = VehicleStatus.Available, LicensePlate = "STU901" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[7].Id, Year = 2021, Color = VehicleColor.Green, DailyPrice = 75, Status = VehicleStatus.Available, LicensePlate = "VWX234" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[8].Id, Year = 2018, Color = VehicleColor.Black, DailyPrice = 65, Status = VehicleStatus.Available, LicensePlate = "YZA567" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[9].Id, Year = 2022, Color = VehicleColor.White, DailyPrice = 95, Status = VehicleStatus.Available, LicensePlate = "BCD890" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[10].Id, Year = 2020, Color = VehicleColor.Red, DailyPrice = 50, Status = VehicleStatus.Available, LicensePlate = "CDE123" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[11].Id, Year = 2019, Color = VehicleColor.Blue, DailyPrice = 60, Status = VehicleStatus.Available, LicensePlate = "EFG456" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[12].Id, Year = 2021, Color = VehicleColor.Green, DailyPrice = 55, Status = VehicleStatus.Available, LicensePlate = "GHI789" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[13].Id, Year = 2018, Color = VehicleColor.Black, DailyPrice = 70, Status = VehicleStatus.Available, LicensePlate = "HIJ012" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[14].Id, Year = 2022, Color = VehicleColor.White, DailyPrice = 80, Status = VehicleStatus.Available, LicensePlate = "IJK345" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[15].Id, Year = 2020, Color = VehicleColor.Red, DailyPrice = 90, Status = VehicleStatus.Available, LicensePlate = "JKL678" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[16].Id, Year = 2019, Color = VehicleColor.Blue, DailyPrice = 85, Status = VehicleStatus.Available, LicensePlate = "KLM901" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[17].Id, Year = 2021, Color = VehicleColor.Green, DailyPrice = 75, Status = VehicleStatus.Available, LicensePlate = "LMN234" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[18].Id, Year = 2018, Color = VehicleColor.Black, DailyPrice = 65, Status = VehicleStatus.Available, LicensePlate = "MNO567" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[19].Id, Year = 2022, Color = VehicleColor.White, DailyPrice = 95, Status = VehicleStatus.Available, LicensePlate = "NOP890" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[0].Id, Year = 2020, Color = VehicleColor.Red, DailyPrice = 50, Status = VehicleStatus.Available, LicensePlate = "OPQ123" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[1].Id, Year = 2019, Color = VehicleColor.Blue, DailyPrice = 60, Status = VehicleStatus.Available, LicensePlate = "PQR456" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[2].Id, Year = 2021, Color = VehicleColor.Green, DailyPrice = 55, Status = VehicleStatus.Available, LicensePlate = "QRS789" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[3].Id, Year = 2018, Color = VehicleColor.Black, DailyPrice = 70, Status = VehicleStatus.Available, LicensePlate = "RST012" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[4].Id, Year = 2022, Color = VehicleColor.White, DailyPrice = 80, Status = VehicleStatus.Available, LicensePlate = "STU345" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[5].Id, Year = 2020, Color = VehicleColor.Red, DailyPrice = 90, Status = VehicleStatus.Available, LicensePlate = "TUV678" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[6].Id, Year = 2019, Color = VehicleColor.Blue, DailyPrice = 85, Status = VehicleStatus.Available, LicensePlate = "UVW901" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[7].Id, Year = 2021, Color = VehicleColor.Green, DailyPrice = 75, Status = VehicleStatus.Available, LicensePlate = "VWX234" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[8].Id, Year = 2018, Color = VehicleColor.Black, DailyPrice = 65, Status = VehicleStatus.Available, LicensePlate = "WXY567" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[9].Id, Year = 2022, Color = VehicleColor.White, DailyPrice = 95, Status = VehicleStatus.Available, LicensePlate = "XYZ890" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[10].Id, Year = 2020, Color = VehicleColor.Red, DailyPrice = 50, Status = VehicleStatus.Available, LicensePlate = "YZA123" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[11].Id, Year = 2019, Color = VehicleColor.Blue, DailyPrice = 60, Status = VehicleStatus.Available, LicensePlate = "ZAB456" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[12].Id, Year = 2021, Color = VehicleColor.Green, DailyPrice = 55, Status = VehicleStatus.Available, LicensePlate = "ABC789" },
        new Vehicle { Id = Guid.NewGuid(), ModelId = Models[13].Id, Year = 2018, Color = VehicleColor.Black, DailyPrice = 70, Status = VehicleStatus.Available, LicensePlate = "BCD012" }
    };

    public static readonly Location[] Locations = new Location[]
    {
        new Location { Id = Guid.NewGuid(), Name = "Ankara Merkez" },
        new Location { Id = Guid.NewGuid(), Name = "Istanbul Avrupa Yakası" },
        new Location { Id = Guid.NewGuid(), Name = "Istanbul Anadolu Yakası" },
        new Location { Id = Guid.NewGuid(), Name = "Izmir Merkez" },
        new Location { Id = Guid.NewGuid(), Name = "Bursa Merkez" },
        new Location { Id = Guid.NewGuid(), Name = "Antalya Merkez" },
        new Location { Id = Guid.NewGuid(), Name = "Adana Merkez" },
        new Location { Id = Guid.NewGuid(), Name = "Mersin Merkez" },
        new Location { Id = Guid.NewGuid(), Name = "Kayseri Merkez" },
        new Location { Id = Guid.NewGuid(), Name = "Konya Merkez" }
    };

    public static readonly Address[] Addresses = new Address[]
    {
        new Address { Id = Guid.NewGuid(), Street = "Atatürk Bulvarı", City = City.Ankara, State = "Çankaya", ZipCode = "06000", LocationId = Locations[0].Id },
        new Address { Id = Guid.NewGuid(), Street = "İstiklal Caddesi", City = City.Istanbul, State = "Beyoğlu", ZipCode = "34430", LocationId = Locations[1].Id },
        new Address { Id = Guid.NewGuid(), Street = "Kordon Boyu", City = City.Izmir, State = "Alsancak", ZipCode = "35220", LocationId = Locations[3].Id },
        new Address { Id = Guid.NewGuid(), Street = "Atatürk Caddesi", City = City.Bursa, State = "Osmangazi", ZipCode = "16010", LocationId = Locations[4].Id },
        new Address { Id = Guid.NewGuid(), Street = "Konyaaltı Caddesi", City = City.Antalya, State = "Konyaaltı", ZipCode = "07070", LocationId = Locations[5].Id },
        new Address { Id = Guid.NewGuid(), Street = "Gazipaşa Bulvarı", City = City.Adana, State = "Çukurova", ZipCode = "01130", LocationId = Locations[6].Id },
        new Address { Id = Guid.NewGuid(), Street = "Gazi Mustafa Kemal Bulvarı", City = City.Mersin, State = "Yenişehir", ZipCode = "33200", LocationId = Locations[7].Id },
        new Address { Id = Guid.NewGuid(), Street = "Sivas Caddesi", City = City.Kayseri, State = "Kocasinan", ZipCode = "38040", LocationId = Locations[8].Id },
        new Address { Id = Guid.NewGuid(), Street = "Doktorlar Caddesi", City = City.Konya, State = "Selçuklu", ZipCode = "42060", LocationId = Locations[9].Id }

    };

    public static readonly Campaign[] Campaigns =
    {
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Yaz İndirimi",
            Description = "Yaz boyunca tüm kiralamalarda %20 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 20,
            IsActive = true
        },
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Kış İndirimi",
            Description = "Kış boyunca tüm kiralamalarda %25 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 25,
            IsActive = true
        },
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Bahar İndirimi",
            Description = "Bahar aylarında tüm kiralamalarda %15 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 15,
            IsActive = true
        },
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Sonbahar İndirimi",
            Description = "Sonbahar boyunca tüm kiralamalarda %18 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 18,
            IsActive = true
        },
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Bayram İndirimi",
            Description = "Bayram süresince tüm kiralamalarda %30 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 30,
            IsActive = true
        },
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Hafta Sonu İndirimi",
            Description = "Hafta sonları yapılan kiralamalarda %10 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 10,
            IsActive = true
        },
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Yılbaşı İndirimi",
            Description = "Yılbaşına özel tüm kiralamalarda %25 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 25,
            IsActive = true
        },
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Haftalık İndirim",
            Description = "Haftalık kiralamalarda %20 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 20,
            IsActive = true
        },
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Aylık İndirim",
            Description = "Aylık kiralamalarda %30 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 30,
            IsActive = true
        },
        new Campaign
        {
            Id = Guid.NewGuid(),
            Title = "Özel Gün İndirimi",
            Description = "Özel günlerde yapılan kiralamalarda %22 indirim!",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddMonths(1),
            DiscountPercentage = 22,
            IsActive = true
        }
    };

    public static readonly Reservation[] Reservations = new[]
    {
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb9"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(-5), TotalCost = 500, PickupLocationId = Locations[0].Id, DropoffLocationId = Locations[1].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("5e88594b-46ae-4dd7-b7c1-c89b9dcd976b"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now.AddDays(-8), EndDate = DateTime.Now.AddDays(-4), TotalCost = 400, PickupLocationId = Locations[2].Id, DropoffLocationId = Locations[3].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("6a869c2b-19ef-4435-a131-f9c894db7d75"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now.AddDays(-7), EndDate = DateTime.Now.AddDays(-3), TotalCost = 300, PickupLocationId = Locations[4].Id, DropoffLocationId = Locations[5].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("d7a8f5c2-09f3-47b3-afe2-4730d0473c8b"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now.AddDays(-6), EndDate = DateTime.Now.AddDays(-2), TotalCost = 200, PickupLocationId = Locations[6].Id, DropoffLocationId = Locations[7].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("e3bfb9e0-2c44-4fd2-8f9e-5c49a0c9c4f1"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(-1), TotalCost = 100, PickupLocationId = Locations[8].Id, DropoffLocationId = Locations[9].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb9"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now.AddDays(-4), EndDate = DateTime.Now.AddDays(0), TotalCost = 600, PickupLocationId = Locations[1].Id, DropoffLocationId = Locations[2].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("5e88594b-46ae-4dd7-b7c1-c89b9dcd976b"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(1), TotalCost = 700, PickupLocationId = Locations[3].Id, DropoffLocationId = Locations[4].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("6a869c2b-19ef-4435-a131-f9c894db7d75"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now.AddDays(-2), EndDate = DateTime.Now.AddDays(2), TotalCost = 800, PickupLocationId = Locations[5].Id, DropoffLocationId = Locations[6].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("d7a8f5c2-09f3-47b3-afe2-4730d0473c8b"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now.AddDays(3), TotalCost = 900, PickupLocationId = Locations[7].Id, DropoffLocationId = Locations[8].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("e3bfb9e0-2c44-4fd2-8f9e-5c49a0c9c4f1"), VehicleId = Vehicles[0].Id, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(4), TotalCost = 1000, PickupLocationId = Locations[9].Id, DropoffLocationId = Locations[0].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb9"), VehicleId = Vehicles[1].Id, StartDate = DateTime.Now.AddDays(-35), EndDate = DateTime.Now.AddDays(-30), TotalCost = 1000, PickupLocationId = Locations[9].Id, DropoffLocationId = Locations[0].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb9"), VehicleId = Vehicles[2].Id, StartDate = DateTime.Now.AddDays(-27), EndDate = DateTime.Now.AddDays(-25), TotalCost = 1000, PickupLocationId = Locations[9].Id, DropoffLocationId = Locations[0].Id },
        new Reservation { Id = Guid.NewGuid(), UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb9"), VehicleId = Vehicles[3].Id, StartDate = DateTime.Now.AddDays(-22), EndDate = DateTime.Now.AddDays(-20), TotalCost = 1000, PickupLocationId = Locations[9].Id, DropoffLocationId = Locations[0].Id }
    };

    public static readonly Review[] Reviews = new[]
    {
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[0].Id, Comment = "Harika bir deneyimdi!", Rating = 5 },
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[1].Id, Comment = "İyi hizmet.", Rating = 4 },
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[2].Id, Comment = "Memnun kaldım.", Rating = 4 },
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[3].Id, Comment = "Fena değil.", Rating = 3 },
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[4].Id, Comment = "Geliştirilebilir.", Rating = 2 },
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[5].Id, Comment = "Mükemmel!", Rating = 5 },
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[6].Id, Comment = "Çok iyi.", Rating = 4 },
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[7].Id, Comment = "Orta seviyede.", Rating = 3 },
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[8].Id, Comment = "Kötü.", Rating = 2 },
        new Review { Id = Guid.NewGuid(), ReservationId = Reservations[9].Id, Comment = "Berbat.", Rating = 1 },
    };


}
