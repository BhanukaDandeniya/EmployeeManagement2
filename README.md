# Employee Management System with Entity Framework Core

A robust employee management system built with ASP.NET Core MVC using Entity Framework Core for data access. This application demonstrates the implementation of CRUD operations using Code First approach with EF Core ORM.

## 🚀 Features

- **Employee Management**
  - Full CRUD operations (Create, Read, Update, Delete)
  - Clean architecture using repository pattern# Employee Management System with Entity Framework Core
A comprehensive employee management system built with ASP.NET Core Web API using Entity Framework Core for MySQL data access. This application provides REST API endpoints for managing employee records.

## 🚀 Features
- **Employee Management**
  - Get all employees 
  - Get employee by ID
  - Add new employee
  - Update employee details
  - Delete employee
  

- **Entity Framework Features**
  - Code First approach
  - Migration support
  - Entity configurations
  - Repository pattern implementation

## 🛠️ Technologies Used
- ASP.NET Core Web API
- Entity Framework Core
- MySQL
- Pomelo.EntityFrameworkCore.MySql
- Swagger UI for API documentation

## 📋 Prerequisites
- Visual Studio 2022 (or later)
- .NET 6.0 SDK or later
- MySQL Server
- MySQL Workbench

## ⚙️ Setup Instructions
1. **Clone the Repository**
   ```bash
   git clone https://github.com/BhanukaDandeniya/EmployeeManagement2.git
   cd EmployeeManagement2
   ```

2. **Update Connection String**
   - Open `appsettings.json`
   - Update the connection string:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=employeedb_ef;Uid=root;Pwd=your_password;"
   }
   ```

3. **Apply Migrations**
   In Package Manager Console:
   ```powershell
   Add-Migration InitialCreate
   Update-Database
   ```

4. **Build and Run**
   - Restore NuGet packages
   - Build the solution
   - Run the application

## 📁 Project Structure
```
EmployeeManagement2/
├── Controllers/
│   └── EmployeeController.cs
├── Models/
│   └── Employee.cs
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Configurations/
├── Repository/
│   ├── IEmployeeRepository.cs
│   └── EmployeeRepository.cs
└── Properties/
    └── launchSettings.json
```

## 💻 API Endpoints
1. **GET /api/employees**
   - Retrieves all employees
   - Optional query parameters for search and filter

2. **GET /api/employees/{id}**
   - Retrieves specific employee by ID

3. **POST /api/employees**
   - Creates new employee
   - Request body: Employee object

4. **PUT /api/employees/{id}**
   - Updates existing employee
   - Request body: Employee object

5. **DELETE /api/employees/{id}**
   - Deletes employee by ID

## ⚠️ Common Issues and Troubleshooting
1. **Migration Issues**
   - Delete the Migrations folder
   - Remove database
   - Re-run migration commands

2. **Connection Issues**
   - Verify MySQL Server is running
   - Check connection string
   - Ensure proper user permissions

## 🤝 Contributing
1. Fork the repository
2. Create a new branch
3. Make your changes
4. Submit a pull request

## 📝 License
This project is licensed under the MIT License - see the LICENSE file for details.

## 👥 Authors
- Bhanuka Dandeniya

## 📧 Support
For support and queries, please create an issue in the repository.
  - Asynchronous operations for better performance
  - Data validation using Data Annotations
  - Responsive UI with Bootstrap

- **Entity Framework Core Features**
  - Code First approach
  - Migration support
  - Fluent API configurations
  - Automated database creation
  - Entity relationships management

## 🛠️ Technologies Used

- ASP.NET Core API (.NET 6)
- Entity Framework Core 6
- SQL Server
- Bootstrap 5
- jQuery
- JavaScript/AJAX
- HTML5/CSS3

## 📋 Prerequisites

- Visual Studio 2022 (or later)
- .NET 6.0 SDK
- SQL Server 2019 (or later)
- SQL Server Management Studio (SSMS)

## ⚙️ Setup Instructions

1. **Clone the Repository**
   ```bash
   git clone https://github.com/BhanukaDandeniya/EmployeeManagement2.git
   cd EmployeeManagement2
   ```

2. **Database Setup**
   - Update the connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=EmployeeDB_EF;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```

3. **Apply Database Migrations**
   - Open Package Manager Console in Visual Studio
   - Run the following commands:
   ```powershell
   Add-Migration InitialCreate
   Update-Database
   ```

4. **Build and Run**
   - Build the solution (Ctrl + Shift + B)
   - Press F5 to run the application

## 📁 Project Structure

```
EmployeeManagement2/
├── Controllers/
│   └── EmployeeController.cs
├── Models/
│   ├── Employee.cs
│   └── ViewModels/
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Configurations/
├── Repository/
│   ├── IEmployeeRepository.cs
│   └── EmployeeRepository.cs
├── Views/
│   └── Employee/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       └── Delete.cshtml
└── wwwroot/
    ├── css/
    └── js/
```

## 🔄 Data Models

### Employee Model
```csharp
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}
```

## 💻 Usage

1. **View Employees**
   - Navigate to the homepage
   - View paginated list of employees
   - Use search and filter functionality

2. **Add New Employee**
   - Click "Add New Employee"
   - Fill the required fields
   - Submit the form

3. **Edit Employee**
   - Click "Edit" on any employee record
   - Update the information
   - Save changes

4. **Delete Employee**
   - Click "Delete" on the employee record
   - Confirm deletion

## 🔍 Repository Pattern Implementation

```csharp
public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllAsync();
    Task<Employee> GetByIdAsync(int id);
    Task AddAsync(Employee employee);
    Task UpdateAsync(Employee employee);
    Task DeleteAsync(int id);
}
```

## ⚠️ Troubleshooting

1. **Migration Issues**
   - Delete the Migrations folder
   - Remove database
   - Re-run migration commands

2. **Entity Framework Errors**
   - Update NuGet packages
   - Clean solution and rebuild
   - Check connection string

## 🔐 Best Practices Implemented

1. **Repository Pattern**
   - Separation of concerns
   - Dependency injection
   - Interface-based programming

2. **Data Access**
   - Async/await pattern
   - Proper disposal of DbContext
   - Error handling

3. **Security**
   - Input validation
   - Data sanitization
   - SQL injection prevention through EF Core

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## 📝 License

This project is licensed under the MIT License.

## 👥 Authors

- Bhanuka Dandeniya

## 📧 Support

For support and queries:
1. Create an issue in the repository
2. Document any bugs with steps to reproduce

## 🔄 Version History

- 1.0.0
    - Initial Release
    - Basic CRUD operations
    - Entity Framework Core implementation

## 📚 Additional Resources

- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)
- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
