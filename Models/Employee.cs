using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models;

public class Employee
{
  [Required]
  public Guid EmployeeId { get; set; }

  [Required]
  [StringLength(50)]
  public string FirstName { get; set; }

  [Required]
  [StringLength(50)]
  public string LastName { get; set; }

  [Required]
  [EmailAddress]
  public string Email { get; set; }

  [Required]
  [Phone]
  public string PhoneNumber { get; set; }

  [Required]
  [StringLength(100)]
  public string Address { get; set; }

  [Required]
  [DataType(DataType.Date)]
  [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
  [DateNotInTheFuture]
  public DateTime StartDate { get; set; }

  [Required]
  [StringLength(50)]
  public string Department { get; set; }

  [Required]
  [StringLength(50)]
  public string Status { get; set; }
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