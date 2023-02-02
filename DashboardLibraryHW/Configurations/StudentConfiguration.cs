using DashboardLibraryHW.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLibraryHW.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasColumnType("nvarchar(max)");

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasColumnType("nvarchar(max)");

        builder.HasOne(x => x.Group)
            .WithMany(x => x.Students)
            .HasForeignKey(x => x.Id_Group);
    }
}
