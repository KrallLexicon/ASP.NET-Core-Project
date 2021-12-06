using ASP.NET_Core_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CarModel> Cars { get; set; }
        public DbSet<OwnerModel> Owners { get; set; }
        public DbSet<CarOwnerModel> CarOwners { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CarOwnerModel>().HasKey(co => new { co.CarId, co.OwnerId });

            modelBuilder.Entity<CarOwnerModel>()
                .HasOne(co => co.Owner)
                .WithMany(o => o.CarOwners)
                .HasForeignKey(co => co.OwnerId);

            modelBuilder.Entity<CarOwnerModel>()
                .HasOne(co => co.Car)
                .WithMany(c => c.CarOwners)
                .HasForeignKey(co => co.CarId);



            modelBuilder.Entity<CarModel>().HasData(new CarModel { Id=1, Brand = "Volvo", Model = "V70", RegNumber = "ABC-123" });
            modelBuilder.Entity<CarModel>().HasData(new CarModel { Id=2, Brand = "SAAB", Model = "93", RegNumber = "DEF-456" });
            modelBuilder.Entity<CarModel>().HasData(new CarModel { Id=3, Brand = "BMW", Model = "E38", RegNumber = "GHI-789" });

            modelBuilder.Entity<OwnerModel>().HasData(new OwnerModel { Name = "Jonathan Krall", SSN = "1234567980" });
            modelBuilder.Entity<OwnerModel>().HasData(new OwnerModel { Name = "Anna Andersson", SSN = "4564513221" });
            modelBuilder.Entity<OwnerModel>().HasData(new OwnerModel { Name = "Robin Robinsson", SSN = "523423423" });

            modelBuilder.Entity<CarOwnerModel>().HasData(new CarOwnerModel { CarId = 1, OwnerId = "1234567980" });
            modelBuilder.Entity<CarOwnerModel>().HasData(new CarOwnerModel { CarId = 2, OwnerId = "1234567980" });
            modelBuilder.Entity<CarOwnerModel>().HasData(new CarOwnerModel { CarId = 3, OwnerId = "1234567980" });
            modelBuilder.Entity<CarOwnerModel>().HasData(new CarOwnerModel { CarId = 1, OwnerId = "523423423" });

        }
    }
}
