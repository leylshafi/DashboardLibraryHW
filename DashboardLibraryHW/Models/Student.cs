using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DashboardLibraryHW.Models;

public class Student : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id_Group { get; set; }
    // Navigation Property
    public Group? Group { get; set; }
    public List<S_Cards>? S_Cards { get; set; }
}