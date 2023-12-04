using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using EmployeeApi.Controllers;
using EmployeeApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Tests;

public class EmployeesControllerTests
{
    private EmployeesController controller;

    public EmployeesControllerTests()
    {
        // Arrage: Setupa mock database context and EmployeesController
    }

    /*
        Test scenarios: 

        1. `GET: api/Employees`
            - Test when the database is empty. Expect an empty array.
            - Test when the database has one or more employees. Expect 200 with employee object(s).
        2. `GET: api/Employees/{id}`
            - Test when the specified employee ID does not exist in the database. Expect 404.
            - Test when the specified employee ID exists in the database. Expect 200 with the correct employee object.
        3. `PUT: api/Employees/{id}`
            - Test when the specified employee ID does not match the ID in the request body. Expect 400.
            - Test when the model state is invalid. Expect 400.
            - Test when an employee with the same email already exists. Expect 409.
            - Test when the specified employee ID exists in the database and the model is valid. Expect 204.
        4. `POST: api/Employees`
            - Test when the model state is invalid. Expect 400.
            - Test when an employee with the same email already exists. Expect 409.
            - Test when an employee with the same ID already exists. Expect 409.
            - Test when the request is valid. Expect 201 with correct employee object.
        5. `DELETE: api/Employees/{id}`
            - Test when the specified employee ID does not exist in the database. Expect 404.
            - Test when the specified employee ID exists in the database. Expect 204.
    */

}