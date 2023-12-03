using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models;

public class Employee
{
  public string? EmployeeId { get; set; }

  [Required]
  [StringLength(50)]
  public required string FirstName { get; set; }

  [Required]
  [StringLength(50)]
  public required string LastName { get; set; }

  [Required]
  [EmailAddress]
  public required string Email { get; set; }

  [Required]
  [Phone]
  public required string PhoneNumber { get; set; }

  [Required]
  [StringLength(100)]
  public required string Address { get; set; }

  [Required]
  [DataType(DataType.Date)]
  [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
  [DateNotInTheFuture]
  public DateTime StartDate { get; set; }

  [Required]
  [StringLength(50)]
  public required string Department { get; set; }

  [Required]
  [StringLength(50)]
  public required string Status { get; set; }
}

public class DateNotInTheFutureAttribute : ValidationAttribute
{
  public override bool IsValid(object value)
  {
    DateTime date;
    if (DateTime.TryParse(value.ToString(), out date))
    {
      if (date > DateTime.Now)
      {
        return false;
      }
    }
    return true;
  }
}