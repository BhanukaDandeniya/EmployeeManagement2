# Employee Management System with Entity Framework Core
A comprehensive employee management system built with ASP.NET Core Web API using Entity Framework Core for MySQL data access. This application provides REST API endpoints for managing employee records.

## 🚀 Features
- **Employee Management**
  - Get all employees 
  - Get employee by ID
  - Add new employee
  - Update employee details
  - Delete employee
  - Search and filter capabilities

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
