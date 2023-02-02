using DashboardLibraryHW.Configurations;
using DashboardLibraryHW.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLibraryHW.Contexts;

class LibraryDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("LibraryDb"));
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new LibsConfiguration());
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new GroupConfiguration());
        modelBuilder.ApplyConfiguration(new PressConfiguration());
        modelBuilder.ApplyConfiguration(new ThemeConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new T_CardsConfiguration());
        modelBuilder.ApplyConfiguration(new S_CardsConfiguration());
        modelBuilder.ApplyConfiguration(new FacultyConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Press> Presses { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Libs> Libs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<S_Cards> S_Cards { get; set; }
    public DbSet<T_Cards> T_Cards { get; set; }
}
