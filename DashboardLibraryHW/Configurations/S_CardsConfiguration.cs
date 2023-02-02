using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashboardLibraryHW.Models;

namespace DashboardLibraryHW.Configurations;

public class S_CardsConfiguration : IEntityTypeConfiguration<S_Cards>
{
    public void Configure(EntityTypeBuilder<S_Cards> builder)
    {
        builder.Property(x => x.DateOut)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

        builder.Property(x => x.DateIn)
            .IsRequired(false);

        builder.HasOne(x => x.Student)
            .WithMany(x => x.S_Cards)
            .HasForeignKey(x => x.Id_Student);

        builder.HasOne(x => x.Lib)
            .WithMany(x => x.S_Cards)
            .HasForeignKey(x => x.Id_Lib);

        builder.HasOne(x => x.Book)
            .WithMany(x => x.S_Cards)
            .HasForeignKey(x => x.Id_Book);
    }
}