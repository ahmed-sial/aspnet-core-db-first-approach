using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataBaseFirstApproach.Models;

public partial class Student
{
    public int Id { get; set; }

    [Display(Name = "First Name")]
    public string FName { get; set; } = null!;

    [Display(Name = "Last Name")]
    public string LName { get; set; } = null!;

    [Range(0.0, 4.0)]
    [Display(Name = "CGPA")]
    public decimal Cgpa { get; set; }
}
