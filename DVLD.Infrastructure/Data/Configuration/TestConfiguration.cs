using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.ToTable("Tests");
            builder.HasKey(t => t.TestID);

            builder.HasOne(t => t.TestAppointment).WithOne(ta => ta.Test).HasForeignKey<Test>(t => t.TestAppointmentID);
        }
    }
}
