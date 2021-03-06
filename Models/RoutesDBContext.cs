using System;
using Microsoft.EntityFrameworkCore;
using CryptSharp.Core;

namespace CoreRoutes.Models{

    public class RoutesDBContext : DbContext{

        public RoutesDBContext(DbContextOptions<RoutesDBContext> options) : base(options){

        }

        public DbSet<Company> Companies {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<Role> Roles {get;set;}
        public DbSet<ServiceType> ServiceTypes {get;set;}
        public DbSet<Weekday> Weekdays {get;set;}
        public DbSet<CompanySite> CompanySites {get;set;}
        public DbSet<Route> Routes {get;set;}
        public DbSet<Vehicle> Vehicles {get;set;}
        public DbSet<DeliveryState> DeliveryStates {get;set;}
        public DbSet<DeliveryChecking> DeliveryCheckings {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Catalogos
            SeedDeliveryStates(modelBuilder);
            SeedWeekdays(modelBuilder);
            SeedVehicles(modelBuilder);
            SeedRoles(modelBuilder);
            
            //Dependencias
            SeedUsers(modelBuilder);
        }

        private void SeedRoles(ModelBuilder builder){
            builder.Entity<Role>().HasData(
                new Role{Id = 1, UserRole = "Admin", CreateAt = DateTime.Now, UpdateAt = DateTime.Now},
                new Role{Id = 2, UserRole = "Manager", CreateAt = DateTime.Now, UpdateAt = DateTime.Now},
                new Role{Id = 3, UserRole = "Driver", CreateAt = DateTime.Now, UpdateAt = DateTime.Now}
            );
        }

        private void SeedUsers(ModelBuilder builder){
            builder.Entity<User>().HasData(
                new User{
                    Id = 1, 
                    Username = "eretana", 
                    Email = "eretana60@gmail.com",
                    Password = Crypter.Blowfish.Crypt("eretana1234"),
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    RoleFK = 1
                },
                new User{
                    Id = 2,
                    Username = "hectormarcia", 
                    Email = "hector@gmail.com",
                    Password = Crypter.Blowfish.Crypt("hector123"),
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    RoleFK = 3
                }
            );
        }

        private void SeedWeekdays(ModelBuilder builder){
            builder.Entity<Weekday>().HasData(
                new Weekday{Id = 1, DayName = "Monday"},
                new Weekday{Id = 2, DayName = "Tuesday"},
                new Weekday{Id = 3, DayName = "Wednesday"},
                new Weekday{Id = 4, DayName = "Thursday"},
                new Weekday{Id = 5, DayName = "Friday"},
                new Weekday{Id = 6, DayName = "Saturday"},
                new Weekday{Id = 7, DayName = "Sunday"}
            );
        }

        private void SeedVehicles(ModelBuilder builder){
            builder.Entity<Vehicle>().HasData(
                new Vehicle{Id = 1, VehicleName="Pickup"},
                new Vehicle{Id = 2, VehicleName="Straight Truck"},
                new Vehicle{Id = 3, VehicleName="Trailer Truck"}
            );
        }

        private void SeedDeliveryStates(ModelBuilder builder){
            builder.Entity<DeliveryState>().HasData(
                new DeliveryState{Id=1, State="Available"},
                new DeliveryState{Id=2, State="Selected"},
                new DeliveryState{Id=3, State="Working"},
                new DeliveryState{Id=4, State="Delivered"},
                new DeliveryState{Id=5, State="Skipped"},
                new DeliveryState{Id=6, State="Undelivered"}
            );
        }

    }

}