using DashboardLibraryHW.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLibraryHW.Configurations;

class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.Property(x => x.FirstName)
             .IsRequired()
             .HasColumnType("nvarchar(max)");

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasColumnType("nvarchar(max)");
    }
}
