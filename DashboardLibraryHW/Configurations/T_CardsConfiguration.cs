using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashboardLibraryHW.Models;

namespace DashboardLibraryHW.Configurations;

public class T_CardsConfiguration : IEntityTypeConfiguration<T_Cards>
{
    public void Configure(EntityTypeBuilder<T_Cards> builder)
    {
        builder.Property(x => x.DateOut)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(x => x.DateIn)
            .IsRequired(false);

        builder.HasOne(x => x.Teacher)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Teacher);

        builder.HasOne(x => x.Lib)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Lib);

        builder.HasOne(x => x.Book)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Book);
    }
}
