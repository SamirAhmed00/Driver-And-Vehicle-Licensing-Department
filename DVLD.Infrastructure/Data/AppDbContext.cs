using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DVLD.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // DbSets for all entities
        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DVLD.Domain.Entities.Application> Applications { get; set; }
        public DbSet<ApplicationType> ApplicationTypes { get; set; }
        public DbSet<LocalDrivingLicenseApplication> LocalDrivingLicenseApplications { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<LicenseClass> LicenseClasses { get; set; }
        public DbSet<InternationalLicense> InternationalLicenses { get; set; }
        public DbSet<DetainedLicense> DetainedLicenses { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
        public DbSet<TestAppointment> TestAppointments { get; set; }
        public DbSet<Test> Tests { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Apply configurations for all entities
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
