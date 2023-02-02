using DashboardLibraryHW.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLibraryHW.Configurations;

public class PressConfiguration : IEntityTypeConfiguration<Press>
{
    public void Configure(EntityTypeBuilder<Press> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("nvarchar(30)");
    }
}
