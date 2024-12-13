using Car_Dealership.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Dealership.Services
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Добавляем пользователей
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", Password = "admin123", AccessLevel = 1 },
                new User { Id = 2, Username = "manager", Password = "manager123", AccessLevel = 2 },
                new User { Id = 3, Username = "client", Password = "client123", AccessLevel = 3 }
            );

            // Добавляем автомобили
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Manufacturer = "Audi", Model = "A7", HorsePower = 340, ProductionYear = 2022, Price = 6000000, AccessLevel = 2 },
                new Car { Id = 2, Manufacturer = "Audi", Model = "RS7", HorsePower = 600, ProductionYear = 2023, Price = 18000000, AccessLevel = 1 },
                new Car { Id = 3, Manufacturer = "BMW", Model = "M850i", HorsePower = 620, ProductionYear = 2021, Price = 17000000, AccessLevel = 1 },
                new Car { Id = 4, Manufacturer = "BMW", Model = "M340i", HorsePower = 320, ProductionYear = 2023, Price = 4500000, AccessLevel = 2 },
                new Car { Id = 5, Manufacturer = "Porsche", Model = "Cayman 4s", HorsePower = 350, ProductionYear = 2017, Price = 4000000, AccessLevel = 3 },
                new Car { Id = 6, Manufacturer = "Mercedes-Benz", Model = "S-Class", HorsePower = 490, ProductionYear = 2020, Price = 10000000, AccessLevel = 1 },
                new Car { Id = 7, Manufacturer = "Tesla", Model = "Model S", HorsePower = 1020, ProductionYear = 2023, Price = 8000000, AccessLevel = 1 },
                new Car { Id = 8, Manufacturer = "Ford", Model = "Mustang", HorsePower = 450, ProductionYear = 2022, Price = 5500000, AccessLevel = 3 },
                new Car { Id = 9, Manufacturer = "Chevrolet", Model = "Corvette", HorsePower = 495, ProductionYear = 2022, Price = 7000000, AccessLevel = 1 },
                new Car { Id = 10, Manufacturer = "Toyota", Model = "Supra", HorsePower = 335, ProductionYear = 2023, Price = 4000000, AccessLevel = 2 },
                new Car { Id = 11, Manufacturer = "Nissan", Model = "GT-R", HorsePower = 565, ProductionYear = 2020, Price = 9000000, AccessLevel = 1 },
                new Car { Id = 12, Manufacturer = "Ferrari", Model = "Roma", HorsePower = 612, ProductionYear = 2022, Price = 24000000, AccessLevel = 2 },
                new Car { Id = 13, Manufacturer = "Lamborghini", Model = "Huracán", HorsePower = 640, ProductionYear = 2022, Price = 26000000, AccessLevel = 1 },
                new Car { Id = 14, Manufacturer = "Jaguar", Model = "F-Type", HorsePower = 575, ProductionYear = 2023, Price = 8000000, AccessLevel = 3 },
                new Car { Id = 15, Manufacturer = "Maserati", Model = "GranTurismo", HorsePower = 550, ProductionYear = 2022, Price = 12000000, AccessLevel = 2 },
                new Car { Id = 16, Manufacturer = "Aston Martin", Model = "DB11", HorsePower = 503, ProductionYear = 2022, Price = 19000000, AccessLevel = 1 },
                new Car { Id = 17, Manufacturer = "Bugatti", Model = "Chiron", HorsePower = 1500, ProductionYear = 2023, Price = 30000000, AccessLevel = 1 },
                new Car { Id = 18, Manufacturer = "Rolls-Royce", Model = "Phantom", HorsePower = 563, ProductionYear = 2023, Price = 28000000, AccessLevel = 1 },
                new Car { Id = 19, Manufacturer = "Bentley", Model = "Continental GT", HorsePower = 626, ProductionYear = 2023, Price = 25000000, AccessLevel = 1 },
                new Car { Id = 20, Manufacturer = "McLaren", Model = "720S", HorsePower = 710, ProductionYear = 2023, Price = 25000000, AccessLevel = 1 }
            );
        }
    }
}
