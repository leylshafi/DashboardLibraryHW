using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLibraryHW.Models;

public class Teacher : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id_Dep { get; set; }
    // Navigation Property
    public Department? Department { get; set; }
    public List<T_Cards>? T_Cards { get; set; }
}
