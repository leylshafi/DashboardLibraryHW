using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLibraryHW.Models;

public class Libs : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    // Navigation Property
    public List<T_Cards>? T_Cards { get; set; }
    public List<S_Cards>? S_Cards { get; set; }
}
