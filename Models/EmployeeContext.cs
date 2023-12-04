using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Models;

public class EmployeeContext : DbContext
{
  public EmployeeContext(DbContextOptions<EmployeeContext> options)
      : base(options)
  {
  }

  public DbSet<Employee> Employees { get; set; } = null!;

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Employee>()
        .HasIndex(e => e.Email)
        .IsUnique();

    // Seed the database with data from employees.json
    var employeesJson = File.ReadAllText("../data/employees.json");
    var employees = JsonSerializer.Deserialize<List<Employee>>(employeesJson);
    modelBuilder.Entity<Employee>().HasData(employees);
  }

}