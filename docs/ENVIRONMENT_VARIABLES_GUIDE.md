# Environment Variables Guide for ServeHub

## Overview

This guide explains how to use environment variables to manage configuration for the ServeHub project, particularly for database connection strings and other sensitive settings.

## Why Use Environment Variables?

Environment variables provide several benefits:

1. **Security**: Keeps sensitive data (passwords, API keys) out of source control
2. **Flexibility**: Different configurations for development, staging, and production
3. **Best Practice**: Industry standard for managing application configuration
4. **Deployment**: Easy to configure in cloud environments (Azure, AWS, etc.)

## Setting Environment Variables

### Windows (Command Prompt)

```cmd
set ConnectionStrings__DefaultConnection="Server=tcp:servehub-sqlserver.database.windows.net,1433;Initial Catalog=ServeHubDB;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=False;Connection Timeout=30;"
```

### Windows (PowerShell)

```powershell
$env:ConnectionStrings__DefaultConnection = "Server=tcp:servehub-sqlserver.database.windows.net,1433;Initial Catalog=ServeHubDB;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=False;Connection Timeout=30;"
```

### macOS/Linux (Bash)

```bash
export ConnectionStrings__DefaultConnection="Server=tcp:servehub-sqlserver.database.windows.net,1433;Initial Catalog=ServeHubDB;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=False;Connection Timeout=30;"
```

## Project-Specific Environment Variables

### Database Connection Strings

#### Development (LocalDB)

**Windows (Command Prompt)**:
```cmd
set ConnectionStrings__DefaultConnection="Server=(localdb)\mssqllocaldb;Database=ServeHubDb;Trusted_Connection=true;MultipleActiveResultSets=true"
set ASPNETCORE_ENVIRONMENT=Development
```

**Windows (PowerShell)**:
```powershell
$env:ConnectionStrings__DefaultConnection = "Server=(localdb)\mssqllocaldb;Database=ServeHubDb;Trusted_Connection=true;MultipleActiveResultSets=true"
$env:ASPNETCORE_ENVIRONMENT = "Development"
```

#### Production (Azure SQL)

**Windows (Command Prompt)**:
```cmd
set ConnectionStrings__DefaultConnection="Server=tcp:servehub-sqlserver.database.windows.net,1433;Initial Catalog=ServeHubDB;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=False;Connection Timeout=30;"
set ASPNETCORE_ENVIRONMENT=Production
```

**Windows (PowerShell)**:
```powershell
$env:ConnectionStrings__DefaultConnection = "Server=tcp:servehub-sqlserver.database.windows.net,1433;Initial Catalog=ServeHubDB;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=False;Connection Timeout=30;"
$env:ASPNETCORE_ENVIRONMENT = "Production"
```

### Other Configuration Variables

```bash
# Logging levels
export Logging__LogLevel__Default=Information
export Logging__LogLevel__Microsoft_AspNetCore=Warning

# Allowed hosts
export AllowedHosts=*
```

## Running the Application with Environment Variables

### Using Command Line

After setting environment variables, run:

```bash
dotnet run
```

### Using launchSettings.json

You can also configure environment variables in `Properties/launchSettings.json`:

```json
{
  "profiles": {
    "ServeHub": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "applicationUrl": "https://localhost:5001;http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "ConnectionStrings__DefaultConnection": "Server=(localdb)\mssqllocaldb;Database=ServeHubDb;Trusted_Connection=true;MultipleActiveResultSets=true"
      }
    }
  }
}
```

## Running Migrations with Environment Variables

### Development Migrations (LocalDB)

```bash
# Set environment variable (Windows PowerShell)
$env:ConnectionStrings__DefaultConnection = "Server=(localdb)\mssqllocaldb;Database=ServeHubDb;Trusted_Connection=true;MultipleActiveResultSets=true"

# Create migration
dotnet ef migrations add InitialCreate --output-dir Data/Migrations

# Apply migration
dotnet ef database update
```

### Production Migrations (Azure SQL)

```bash
# Set environment variable (Windows PowerShell)
$env:ConnectionStrings__DefaultConnection = "Server=tcp:servehub-sqlserver.database.windows.net,1433;Initial Catalog=ServeHubDB;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=False;Connection Timeout=30;"

# Apply migration to production
dotnet ef database update
```

## Permanent Environment Variables

### Windows

#### System-wide (requires admin rights)

```cmd
setx ConnectionStrings__DefaultConnection "Server=tcp:servehub-sqlserver.database.windows.net,1433;Initial Catalog=ServeHubDB;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=False;Connection Timeout=30;" /M
```

#### User-level

```cmd
setx ConnectionStrings__DefaultConnection "Server=tcp:servehub-sqlserver.database.windows.net,1433;Initial Catalog=ServeHubDB;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=False;Connection Timeout=30;"
```

### macOS/Linux

Add to `~/.bashrc`, `~/.zshrc`, or `~/.profile`:

```bash
export ConnectionStrings__DefaultConnection="Server=tcp:servehub-sqlserver.database.windows.net,1433;Initial Catalog=ServeHubDB;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=False;Connection Timeout=30;"
```

Then reload your shell:

```bash
source ~/.bashrc  # or ~/.zshrc
```

## Using .env Files (Development Only)

For development, you can use a `.env` file with the `dotnet-user-secrets` tool or a package like `DotNetEnv`.

### Using dotnet user-secrets

1. Initialize user secrets:
```bash
dotnet user-secrets init
```

2. Set secrets:
```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=(localdb)\mssqllocaldb;Database=ServeHubDb;Trusted_Connection=true;MultipleActiveResultSets=true"
```

3. Access in code:
The configuration system automatically loads user secrets in development environment.

## Azure Deployment

### Azure App Service

1. Go to your App Service in Azure Portal
2. Navigate to Settings > Configuration
3. Add application settings:
   - Name: `ConnectionStrings__DefaultConnection`
   - Value: Your Azure SQL connection string
   - Type: `SQLAzure`

### Azure Container Apps / Azure Functions

Set environment variables in your deployment configuration:

```yaml
env:
  - name: ConnectionStrings__DefaultConnection
    valueFrom:
      secretRef:
        name: connection-string-secret
```

## Security Best Practices

1. **Never commit** `.env` files or files containing secrets to source control
2. **Add to .gitignore**:
   ```
   .env
   *.user
   appsettings.Production.json
   ```
3. **Use different credentials** for development, staging, and production
4. **Rotate credentials** regularly
5. **Use Azure Key Vault** for production secrets when possible

## Troubleshooting

### Environment Variables Not Loading

1. Verify the environment variable is set:
   ```bash
   # Windows
   echo %ConnectionStrings__DefaultConnection%

   # PowerShell
   $env:ConnectionStrings__DefaultConnection

   # macOS/Linux
   echo $ConnectionStrings__DefaultConnection
   ```

2. Check the ASPNETCORE_ENVIRONMENT:
   ```bash
   # Windows
   echo %ASPNETCORE_ENVIRONMENT%

   # PowerShell
   $env:ASPNETCORE_ENVIRONMENT

   # macOS/Linux
   echo $ASPNETCORE_ENVIRONMENT
   ```

3. Restart your application after setting environment variables

### Connection String Issues

1. Test your connection string with SQL Server Management Studio or Azure Data Studio
2. Verify firewall settings for Azure SQL
3. Check that the database exists and is accessible

## Additional Resources

- [Configuration in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/)
- [Environment Variables in .NET](https://docs.microsoft.com/en-us/dotnet/core/extensions/configuration-providers#environment-variables-configuration-provider)
- [Safe Storage of App Secrets in Development](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets)
- [Azure Key Vault Configuration Provider](https://docs.microsoft.com/en-us/aspnet/core/security/key-vault-configuration)
