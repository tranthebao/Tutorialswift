using System;
using System.Configuration;
using System.IO;
using DotNetReact.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace tutorialcode.DemoContext {
    public class StaffContext : DbContext {
        public StaffContext(DbContextOptions<StaffContext> dbContextOptions) : base(dbContextOptions) {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<City> City { get; set; }
        //
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            /*if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString, x=>x.MigrationsAssembly("tutorial-code")); //or any other DB provider
            }*/
        }
        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating (modelBuilder);
            /*modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeID);
                entity.Property(e => e.Name);
                entity.Property(e => e.City);
                entity.Property(e => e.Department).IsRequired();
                entity.Property(e => e.Gender);
            });
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.CityID);
                entity.Property(e => e.CityName);
            });*/
        }
    }
}