using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class TestAppointmentConfiguration : IEntityTypeConfiguration<TestAppointment>
    {
        public void Configure(EntityTypeBuilder<TestAppointment> builder)
        {
            builder.ToTable("TestAppointments");
            builder.HasKey(ta => ta.TestAppointmentID);
            builder.Property(ta => ta.PaidFees).HasColumnType("decimal(18,2)");

            builder.HasOne(ta => ta.LocalDrivingLicenseApplication)
                   .WithMany(l => l.TestAppointments)
                   .HasForeignKey(ta => ta.LocalDrivingLicenseApplicationID);
        }
    }
}
