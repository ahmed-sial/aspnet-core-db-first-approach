# CRUD Application - Database First Approach

A simple CRUD (Create, Read, Update, Delete) application built using Visual Studio with Entity Framework's Database First approach.

## Overview

This application demonstrates a complete CRUD implementation using the Database First approach, where the database schema is created first and the Entity Framework models are generated from the existing database.

## Features

- ✅ Create new records
- ✅ Read/View existing records
- ✅ Update existing records
- ✅ Delete records
- ✅ Data validation
- ✅ Responsive user interface
- ✅ Database connectivity with Entity Framework

## Technologies Used

- **Framework**: .NET Core/Framework (specify version)
- **IDE**: Visual Studio (specify version)
- **ORM**: Entity Framework (Database First)
- **Database**: SQL Server/MySQL/PostgreSQL (specify which one)
- **Frontend**: ASP.NET MVC/Web API/Blazor (specify which one)
- **Language**: C#

## Prerequisites

Before running this application, make sure you have the following installed:

- Visual Studio 2019/2022 or later
- .NET Core SDK (specify version)
- SQL Server/MySQL/PostgreSQL (specify which database)
- Entity Framework Tools

## Installation

1. **Clone the repository**
   ```bash
   git clone [your-repository-url]
   cd [your-project-name]
   ```

2. **Open the project**
   - Open Visual Studio
   - File → Open → Project/Solution
   - Select the `.sln` file

3. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

## Database Setup

1. **Database Creation**
   - Create your database in SQL Server Management Studio or your preferred database tool
   - Run the provided SQL scripts (if any) to create tables and initial data

2. **Connection String**
   - Update the connection string in `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=your-server;Database=your-database;Trusted_Connection=true;TrustServerCertificate=true;"
     }
   }
   ```

3. **Generate Models (if needed)**
   If you need to regenerate the Entity Framework models:
   ```bash
   Scaffold-DbContext "your-connection-string" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
   ```

## Configuration

1. **Update Connection String**: Modify the connection string in `appsettings.json` to match your database configuration.

2. **Database Migration** (if applicable):
   ```bash
   dotnet ef database update
   ```

## Usage

1. **Run the application**
   - Press `F5` in Visual Studio, or
   - Use the command line:
   ```bash
   dotnet run
   ```

2. **Access the application**
   - Open your browser and navigate to `https://localhost:5001` (or the specified port)

3. **Features Available**
   - Navigate through the application to perform CRUD operations
   - Add new records using the "Create" functionality
   - View existing records in the list/table view
   - Edit records using the "Edit" functionality
   - Delete records using the "Delete" functionality

## Project Structure

```
YourProjectName/
├── Controllers/          # MVC Controllers
├── Models/              # Entity Framework Models (generated from DB)
├── Views/               # Razor Views (if using MVC)
├── Data/                # DbContext and data-related classes
├── wwwroot/             # Static files (CSS, JS, images)
├── appsettings.json     # Configuration file
├── Program.cs           # Application entry point
└── Startup.cs           # Application startup configuration
```

## API Endpoints

If your application includes Web API functionality, document the endpoints here:

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/[controller]` | Get all records |
| GET | `/api/[controller]/{id}` | Get record by ID |
| POST | `/api/[controller]` | Create new record |
| PUT | `/api/[controller]/{id}` | Update existing record |
| DELETE | `/api/[controller]/{id}` | Delete record |

## Database Schema

Provide information about your database tables and relationships:

```sql
-- Example table structure
CREATE TABLE [TableName] (
    Id int IDENTITY(1,1) PRIMARY KEY,
    FirstName nvarchar(50) NOT NULL,
    LastName nvarchar(50) NOT NULL,
    Cgpa DECIMAL(3, 2) CHECK(Cgpa BETWEEN 0.0 AND 4.0)
);
```

## Troubleshooting

**Common Issues:**

1. **Connection String Issues**
   - Verify your database server is running
   - Check the connection string format
   - Ensure proper authentication credentials

2. **Entity Framework Issues**
   - Rebuild the solution
   - Clear NuGet cache: `dotnet nuget locals all --clear`

3. **Port Conflicts**
   - Check if the specified port is already in use
   - Modify the port in `launchSettings.json`

---
*Note:* It has the same output as in one of my previous CRUD project made using code first approach.
