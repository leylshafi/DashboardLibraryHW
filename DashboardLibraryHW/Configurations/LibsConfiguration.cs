using DashboardLibraryHW.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DashboardLibraryHW.Configurations;

public class LibsConfiguration : IEntityTypeConfiguration<Libs>
{
    public void Configure(EntityTypeBuilder<Libs> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasColumnType("nvarchar(15)");

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasColumnType("nvarchar(25)");
    }
}