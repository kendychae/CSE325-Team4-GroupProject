# ServeHub - Quick Reference Commands

## Essential Commands

### Project Setup
```bash
# Clone repository
git clone https://github.com/kendychae/CSE325-Team4-GroupProject.git
cd CSE325-Team4-GroupProject

# Restore packages
dotnet restore

# Build project
dotnet build

# Run application
dotnet run

# Run with hot reload (development)
dotnet watch run
```

### Database Commands
```bash
# Install EF Core tools (one-time)
dotnet tool install --global dotnet-ef

# Create a new migration
dotnet ef migrations add MigrationName

# Apply migrations to database
dotnet ef database update

# Remove last migration
dotnet ef migrations remove

# Drop database
dotnet ef database drop

# View migration list
dotnet ef migrations list

# Generate SQL script from migrations
dotnet ef migrations script
```

### Git Commands
```bash
# Check status
git status

# Create new branch
git checkout -b feature/your-feature-name

# Stage all changes
git add .

# Commit changes
git commit -m "Your commit message"

# Push to remote
git push origin feature/your-feature-name

# Pull latest changes
git pull origin main

# Switch branches
git checkout branch-name

# View commit history
git log --oneline

# Undo last commit (keep changes)
git reset --soft HEAD~1
```

### Testing & Debugging
```bash
# Build in Release mode
dotnet build -c Release

# Run tests (if test project exists)
dotnet test

# Clean build artifacts
dotnet clean

# View detailed build output
dotnet build --verbosity detailed

# Check for outdated packages
dotnet list package --outdated
```

### Package Management
```bash
# Add a NuGet package
dotnet add package PackageName

# Remove a package
dotnet remove package PackageName

# List installed packages
dotnet list package

# Update all packages
dotnet restore
```

## Project File Locations

### Configuration
- **appsettings.json** - Database connection, logging settings
- **Program.cs** - Application startup, service registration
- **ServeHub.csproj** - Project dependencies

### Code Locations
- **Components/Pages/** - Razor pages (routes)
- **Components/Layout/** - Layout components, navigation
- **Data/** - Database context, Identity user
- **Models/** - Domain entities
- **Services/** - Business logic
- **wwwroot/** - Static files (CSS, JS, images)

### Documentation
- **README.md** - Project overview
- **docs/GETTING_STARTED.md** - Setup instructions
- **docs/PROJECT_GUIDE.md** - Team guide
- **docs/Week*_Team_Submission.md** - Weekly reports

## Common URLs

### Local Development
- Application: https://localhost:5001
- Application (HTTP): http://localhost:5000

### Pages
- Home: /
- Opportunities: /opportunities
- Opportunity Details: /opportunities/{id}
- About: /about
- Login: /Account/Login (to implement)
- Register: /Account/Register (to implement)

## Troubleshooting Quick Fixes

### Build Errors
```bash
dotnet clean
dotnet restore
dotnet build
```

### Database Issues
```bash
dotnet ef database drop
dotnet ef database update
```

### Port Conflicts
Edit `Properties/launchSettings.json` - change ports

### Package Issues
```bash
dotnet nuget locals all --clear
dotnet restore
```

### Git Conflicts
```bash
git status
# Resolve conflicts in files
git add .
git commit -m "Resolve merge conflicts"
```

## Useful VS Code Extensions

- C# Dev Kit
- C#
- NuGet Package Manager
- GitLens
- Prettier - Code formatter
- Thunder Client (API testing)

## Useful Visual Studio Features

- **Ctrl+K, Ctrl+D** - Format document
- **F5** - Start debugging
- **Ctrl+F5** - Start without debugging
- **Ctrl+.** - Quick actions and refactorings
- **Ctrl+Shift+B** - Build solution
- **Ctrl+K, Ctrl+C** - Comment selection
- **Ctrl+K, Ctrl+U** - Uncomment selection

## Project Metrics

| Metric | Value |
|--------|-------|
| .NET Version | 10.0 |
| Project Type | Blazor Server |
| Database | SQL Server |
| Authentication | ASP.NET Core Identity |
| Styling | Bootstrap 5 |
| Architecture | Monolithic |

## Support

- **GitHub Issues**: https://github.com/kendychae/CSE325-Team4-GroupProject/issues
- **Project Lead**: Kendahl Chae Bingham
- **Documentation**: See docs/ folder

---

**Pro Tip**: Keep this file open in a browser tab for quick reference while coding!
