# Employee Admin Portal

A simple **ASP.NET Core Web API** project for managing employees.  
This project demonstrates CRUD operations using **Entity Framework Core** with a SQL Server database.

---

## 🚀 Features
- Add new employees
- Update existing employees
- Get employee list
- Delete employees
- DTOs for request/response validation
- Entity Framework Core with Code-First Migrations

---

## 🛠️ Tech Stack
- ASP.NET Core 8 Web API
- Entity Framework Core
- SQL Server
- C#
- Swagger (API documentation)

---

## 📂 Project Structure
```
EmployeeAdminPortal/
│-- Controllers/         # API Controllers
│   └── EmployeesController.cs
│-- Data/                # Database Context
│   └── ApplicationDbContext.cs
│-- Migrations/          # EF Core migrations
│-- Models/              # DTOs and Entities
│-- Properties/          # Project settings
│-- appsettings.json     # Configuration file
│-- Program.cs           # Application entry point

```
---

## 📌 API Endpoints

| Method | Endpoint              | Description           |
|--------|-----------------------|-----------------------|
| GET    | `/api/employees`      | Get all employees     |
| GET    | `/api/employees/{id}` | Get employee by ID    |
| POST   | `/api/employees`      | Add new employee      |
| PUT    | `/api/employees/{id}` | Update employee       |
| DELETE | `/api/employees/{id}` | Delete employee       |


----
## ⚙️ Setup & Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/EmployeeAdminPortal.git
   cd EmployeeAdminPortal
	```