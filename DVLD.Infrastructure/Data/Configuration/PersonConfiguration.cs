using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.Data.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("People");
            builder.HasKey(p => p.PersonID);
            builder.Property(p => p.NationalNo).IsRequired().HasMaxLength(20);
            builder.Property(p => p.Gendor).HasConversion<short>(); // Enum Mapping

            builder.HasOne(p => p.NationalityCountry)
                   .WithMany(c => c.People)
                   .HasForeignKey(p => p.NationalityCountryID);
        }
    }
}
