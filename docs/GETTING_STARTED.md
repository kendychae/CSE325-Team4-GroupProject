# ServeHub - Getting Started Guide

## Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- **Database Option 1:** [SQL Server LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) (included with Visual Studio) or SQL Server
- **Database Option 2:** SQLite (no installation required - included via NuGet)

## Initial Setup

### 1. Clone the Repository

```bash
git clone https://github.com/kendychae/CSE325-Team4-GroupProject.git
cd CSE325-Team4-GroupProject
```

### 2. Restore NuGet Packages

```bash
dotnet restore
```

### 3. Configure Database

The application supports both SQL Server and SQLite. Choose one:

#### Option A: SQL Server LocalDB (Default)

No configuration needed. The application is pre-configured to use SQL Server LocalDB.

#### Option B: SQLite (No SQL Server Installation Required)

1. Open `appsettings.json`
2. Comment out the SQL Server connection string
3. Rename `_SQLiteConnection` to `DefaultConnection`:

```json
"ConnectionStrings": {
  "_DefaultConnection_SQLServer": "Server=(localdb)\\mssqllocaldb;Database=ServeHubDb;Trusted_Connection=true;MultipleActiveResultSets=true",
  "DefaultConnection": "Data Source=ServeHub.db"
}
```

The application automatically detects which database provider to use based on the connection string format.

### 4. Create the Database

Run the following commands to create the database and apply migrations:

```bash
# Create initial migration
dotnet ef migrations add InitialCreate

# Update the database
dotnet ef database update
```

If you don't have the EF Core tools installed globally, install them first:

```bash
dotnet tool install --global dotnet-ef
```

### 5. Run the Application

```bash
dotnet run
```

Or press **F5** in Visual Studio to run with debugging.

The application will be available at:

- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

## First Time User Setup

### Create an Account

1. Navigate to the application in your browser
2. Click "Get Started" or "Sign Up Now" on the home page
3. Fill in your registration details
4. Click "Register" to create your account

### Explore Service Opportunities

1. Click "Opportunities" in the navigation menu
2. Browse available volunteer opportunities
3. Click "View Details" on any opportunity to see more information
4. Register for opportunities you're interested in

### Create a Service Opportunity

1. Log in to your account
2. Click "Create Opportunity" in the navigation menu
3. Fill in the opportunity details:
   - Title
   - Description
   - Location
   - Start and End dates
   - Maximum number of volunteers
   - Category (optional)
   - Image URL (optional)
4. Click "Create" to publish the opportunity

## Project Structure

```
ServeHub/
├── Components/
│   ├── Layout/          # Layout components (NavMenu, MainLayout)
│   └── Pages/           # Razor pages (Home, Opportunities, etc.)
├── Data/                # Database context and Identity user
├── Models/              # Domain models (ServiceOpportunity, ServiceRegistration)
├── Services/            # Business logic services
├── wwwroot/             # Static files (CSS, JS, images)
├── Program.cs           # Application startup and configuration
└── appsettings.json     # Configuration settings
```

## Key Features

### ✅ W7 Requirement Compliance

- **Blazor Web Application**: Monolithic Blazor Server architecture
- **User Authentication**: ASP.NET Core Identity with registration/login
- **CRUD Functionality**: Complete Create, Read, Update, Delete operations for opportunities
- **Database**: Entity Framework Core with SQL Server
- **Responsive Design**: Mobile-friendly using Bootstrap 5
- **User Management**: Role-based access control ready

### Application Features

1. **Service Opportunity Management**
   - Create, view, update, and delete volunteer opportunities
   - Filter by category and status
   - Track volunteer registration counts

2. **User Registration System**
   - Register for opportunities
   - View personal registration history
   - Cancel registrations

3. **Authentication & Authorization**
   - Secure user registration and login
   - Protected routes for authenticated users
   - Session management

4. **Responsive UI**
   - Mobile-first design
   - Bootstrap 5 components
   - Accessible navigation

## Development Workflow

### Creating a New Feature

1. Create a new branch:

   ```bash
   git checkout -b feature/your-feature-name
   ```

2. Make your changes and test locally

3. Commit your changes:

   ```bash
   git add .
   git commit -m "Description of your changes"
   ```

4. Push to GitHub:

   ```bash
   git push origin feature/your-feature-name
   ```

5. Create a Pull Request on GitHub

### Adding a Database Migration

When you modify the database models:

```bash
dotnet ef migrations add YourMigrationName
dotnet ef database update
```

### Running Tests

```bash
dotnet test
```

## Troubleshooting

### Database Connection Issues

#### SQL Server LocalDB Not Installed

If you get "SQL Server LocalDB not found" errors:

**Option 1: Install SQL Server Express**

1. Download [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
2. Run the installer
3. Restart your development environment

**Option 2: Switch to SQLite (Recommended for Quick Setup)**

1. Open `appsettings.json`
2. Comment out the SQL Server connection and use SQLite:
   ```json
   "ConnectionStrings": {
     "_DefaultConnection_SQLServer": "Server=(localdb)\\mssqllocaldb;Database=ServeHubDb;Trusted_Connection=true;MultipleActiveResultSets=true",
     "DefaultConnection": "Data Source=ServeHub.db"
   }
   ```
3. Delete any existing migrations folder (if present)
4. Run migrations again:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

#### Verify SQL Server LocalDB

If you want to use SQL Server:

1. Verify SQL Server LocalDB is installed:

   ```bash
   sqllocaldb info
   ```

2. Create a new instance if needed:

   ```bash
   sqllocaldb create MSSQLLocalDB
   ```

3. Start the instance:
   ```bash
   sqllocaldb start MSSQLLocalDB
   ```

### Authentication/Authorization Errors

If you see errors like "requires a cascading parameter of type Task<AuthenticationState>":

✅ **This has been fixed!** The application now includes:

- `CascadingAuthenticationState` wrapper in `App.razor`
- `IdentityRevalidatingAuthenticationStateProvider` service registration
- All required authentication services properly configured

If you still encounter issues:

1. Make sure you're using the latest code from the repository
2. Clean and rebuild the project:
   ```bash
   dotnet clean
   dotnet restore
   dotnet build
   ```

### Build Errors

If you encounter build errors:

1. Clean the solution:

   ```bash
   dotnet clean
   ```

2. Restore packages:

   ```bash
   dotnet restore
   ```

3. Rebuild:
   ```bash
   dotnet build
   ```

### Port Already in Use

If the default ports are in use, update `Properties/launchSettings.json` to use different ports.

## Additional Resources

- [ASP.NET Core Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [Entity Framework Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
- [ASP.NET Core Identity Documentation](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity)
- [Bootstrap 5 Documentation](https://getbootstrap.com/docs/5.3/)

## Support

For questions or issues:

- Open an issue on GitHub
- Contact the team via the project's communication channel
- Refer to the course materials and documentation

## Contributing

Please see [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines on how to contribute to this project.
