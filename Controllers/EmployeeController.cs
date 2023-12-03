using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>();

        // GET: api/employees
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        // GET: api/employees/{id}
        [HttpGet("{id}")]
        public IActionResult GetEmployee(string id)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // POST: api/employees
        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            employee.EmployeeId = Guid.NewGuid().ToString();
            employees.Add(employee);

            return CreatedAtAction(nameof(GetEmployee), new { id = employee.EmployeeId }, employee);
        }

        // PUT: api/employees/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(string id, [FromBody] Employee updatedEmployee)
        {
            var existingEmployee = employees.FirstOrDefault(e => e.EmployeeId == id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            existingEmployee.FirstName = updatedEmployee.FirstName;
            existingEmployee.LastName = updatedEmployee.LastName;
            existingEmployee.Email = updatedEmployee.Email;
            existingEmployee.PhoneNumber = updatedEmployee.PhoneNumber;
            existingEmployee.Address = updatedEmployee.Address;
            existingEmployee.StartDate = updatedEmployee.StartDate;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Status = updatedEmployee.Status;

            return NoContent();
        }

        // DELETE: api/employees/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(string id)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            employees.Remove(employee);

            return NoContent();
        }
    }
}
