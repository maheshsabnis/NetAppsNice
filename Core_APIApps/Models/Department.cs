using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Core_APIApps.Models;

public partial class Department
{
    [Required(ErrorMessage ="DeptNo is Must")]
    [NonZeroNonNegative(ErrorMessage ="DeptNo value cannot be 0 or -ve")]
    public int DeptNo { get; set; }
    [Required(ErrorMessage = "DeptName is Must")]
    public string DeptName { get; set; } = null!;
    [Required(ErrorMessage = "Capacity is Must")]
    public int Capacity { get; set; }
    [Required(ErrorMessage = "Location is Must")]
    public string Location { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
