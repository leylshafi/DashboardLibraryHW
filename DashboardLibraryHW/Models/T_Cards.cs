﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLibraryHW.Models;
public class T_Cards : BaseEntity
{
    public int Id_Teacher { get; set; }
    public int Id_Book { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime? DateIn { get; set; }
    public int Id_Lib { get; set; }

    // Navigation Property
    public Teacher? Teacher { get; set; }
    public Book? Book { get; set; }
    public Libs? Lib { get; set; }

}
