# Employee Management Application

This application is a simple Employee Management System built with ASP.NET Core and Entity Framework. It allows you to manage employee data.

## Prerequisites

- .NET Core 3.1 or later
- Entity Framework Core 3.1 or later
- SQL Server 2019 or later

## Running the Application

1. Clone the repository to your local machine.
2. Navigate to the root directory of the project in your terminal.
3. Run the command `dotnet restore` to restore the necessary packages.
4. Run the command `dotnet ef database update` to create the database.
5. Run the command `dotnet run` to start the application.

## Accessing Swagger UI

Once the application is running, you can access the Swagger UI to test the API endpoints by navigating to `http://localhost:5000/swagger` or `https://localhost:5001/swagger` in your web browser.

## Application Features

- **Employee Management**: Create, read, update, and delete employees.
- **Validation**: The application includes validation checks such as ensuring the `StartDate` of an employee is not in the future and there are no duplicate `email` attributes among employees.
