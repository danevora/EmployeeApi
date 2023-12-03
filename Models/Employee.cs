using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models;

public class Employee
{
  /// <summary>
  /// The unique identifier for the employee.
  /// </summary>
  public string? EmployeeId { get; set; }

  /// <summary>
  /// The first name of the employee. Max length 50.
  /// </summary>
  [Required]
  [StringLength(50)]
  public required string FirstName { get; set; }

  /// <summary>
  /// The last name of the employee. Max length 50.
  /// </summary>
  [Required]
  [StringLength(50)]
  public required string LastName { get; set; }

  /// <summary>
  /// The email address of the employee.
  /// </summary>
  [Required]
  [EmailAddress]
  public required string Email { get; set; }

  /// <summary>
  /// The phone number of the employee.
  /// </summary>
  [Required]
  [Phone]
  public required string PhoneNumber { get; set; }

  /// <summary>
  /// The address of the employee.
  /// </summary>
  [Required]
  [StringLength(100)]
  public required string Address { get; set; }

  /// <summary>
  /// The date the employee started working.
  /// </summary>
  [Required]
  [DataType(DataType.Date)]
  [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
  [DateNotInTheFuture]
  public DateTime StartDate { get; set; }

  /// <summary>
  /// The department the employee works in.
  /// </summary>
  [Required]
  [StringLength(50)]
  public required string Department { get; set; }

  /// <summary>
  /// The status of the employee.
  /// </summary>
  [Required]
  [StringLength(50)]
  public required string Status { get; set; }
}

/// <summary>
/// Custom validation attribute to ensure that a date is not in the future.
/// </summary>
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