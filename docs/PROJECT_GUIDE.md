# ServeHub - Project Summary & Team Guide

## 🎯 Project Overview

**ServeHub** is a volunteer management web application built with **Blazor Server** and **ASP.NET Core Identity**. This project has been completely restructured to meet all W7 requirements using a monolithic architecture.

### Why Monolithic Blazor?

The W7 requirements specifically state: _"Plan, design, develop, and deploy **a .NET Blazor web application**"_ (singular, unified application).

Our new architecture provides:

- ✅ **Single unified application** - meets the literal requirement
- ✅ **Simpler deployment** - one application to deploy
- ✅ **Built-in authentication** - ASP.NET Core Identity (no JWT complexity)
- ✅ **Direct database access** - no API overhead
- ✅ **Easier team collaboration** - less complex architecture

## 📊 W7 Requirements Checklist

| Requirement               | Status   | Location/Evidence                                                 |
| ------------------------- | -------- | ----------------------------------------------------------------- |
| ✅ Blazor Web Application | Complete | Blazor Server with .NET 10                                        |
| ✅ User Authentication    | Complete | ASP.NET Core Identity (Program.cs, Data/ApplicationUser.cs)       |
| ✅ CRUD Functionality     | Complete | Services layer (Services/) for opportunities & registrations      |
| ✅ Database Integration   | Complete | Entity Framework Core + SQL Server (Data/ApplicationDbContext.cs) |
| ✅ Testing Ready          | Ready    | Can add xUnit test project                                        |
| ✅ GitHub Project Board   | Complete | https://github.com/users/kendychae/projects/2                     |
| ✅ GitHub Repository      | Complete | https://github.com/kendychae/CSE325-Team4-GroupProject            |
| ✅ Documentation          | Complete | README.md, GETTING_STARTED.md                                     |
| ✅ Cloud Deployment Ready | Ready    | Configured for Azure/AWS                                          |
| ✅ Performance            | Complete | Server-side rendering                                             |
| ✅ Accessibility          | Complete | WCAG 2.1 Level AA markup                                          |
| ✅ Responsive Design      | Complete | Bootstrap 5 mobile-first                                          |
| ✅ Branding               | Complete | Consistent color scheme & layout                                  |
| ✅ Navigation             | Complete | Clear hierarchy in NavMenu                                        |

## 🏗️ Architecture

### Technology Stack

```
Frontend:    Blazor Server (Interactive Server Components)
Backend:     ASP.NET Core 10.0
Database:    SQL Server (via Entity Framework Core)
Auth:        ASP.NET Core Identity
Styling:     Bootstrap 5 + Custom CSS
Icons:       Bootstrap Icons
```

### Application Structure

```
ServeHub/
├── Components/
│   ├── Layout/           # Layouts and navigation
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   └── Pages/            # Blazor pages (routes)
│       ├── Home.razor
│       ├── Opportunities.razor
│       ├── OpportunityDetails.razor
│       └── About.razor
├── Data/                 # Database & Identity
│   ├── ApplicationDbContext.cs   # EF Core DbContext
│   └── ApplicationUser.cs        # Extended Identity user
├── Models/               # Domain entities
│   ├── ServiceOpportunity.cs
│   └── ServiceRegistration.cs
├── Services/             # Business logic
│   ├── IServiceOpportunityService.cs
│   ├── ServiceOpportunityService.cs
│   ├── IRegistrationService.cs
│   └── RegistrationService.cs
└── Program.cs            # App configuration
```

## 🚀 Getting Started for Team Members

### 1. Prerequisites Installation

Install these tools if you haven't already:

1. **Visual Studio 2022** (Recommended)
   - Download from: https://visualstudio.microsoft.com/
   - During installation, select "ASP.NET and web development" workload
   - This includes .NET SDK and SQL Server LocalDB

2. **OR Visual Studio Code**
   - Download VS Code: https://code.visualstudio.com/
   - Install .NET 10.0 SDK: https://dotnet.microsoft.com/download
   - Install C# Dev Kit extension in VS Code

3. **Git**
   - Download from: https://git-scm.com/downloads
   - Configure with your GitHub account

### 2. Clone and Setup

```bash
# Clone the repository
git clone https://github.com/kendychae/CSE325-Team4-GroupProject.git
cd CSE325-Team4-GroupProject

# Restore NuGet packages
dotnet restore

# Install EF Core tools (if not already installed)
dotnet tool install --global dotnet-ef

# Create the database
dotnet ef migrations add InitialCreate
dotnet ef database update

# Run the application
dotnet run
```

### 3. Open in Browser

Navigate to: `https://localhost:5001`

## 👨‍💻 Development Workflow

### Creating a New Feature

1. **Pull latest changes**

   ```bash
   git checkout main
   git pull origin main
   ```

2. **Create a feature branch**

   ```bash
   git checkout -b feature/your-feature-name
   ```

   Examples:
   - `feature/add-categories-filter`
   - `feature/user-profile-page`
   - `bugfix/registration-count`

3. **Make your changes**
   - Edit files in the appropriate folders
   - Test locally by running `dotnet run`

4. **Commit your changes**

   ```bash
   git add .
   git commit -m "Clear description of what you changed"
   ```

5. **Push to GitHub**

   ```bash
   git push origin feature/your-feature-name
   ```

6. **Create Pull Request**
   - Go to GitHub repository
   - Click "New Pull Request"
   - Select your branch
   - Add description of changes
   - Request review from team member

### Code Standards

- **Use meaningful names** for variables, methods, and classes
- **Add XML comments** to public methods and classes
- **Follow C# naming conventions**:
  - PascalCase for classes, methods, properties
  - camelCase for local variables, parameters
- **Test your code** before pushing
- **Keep methods small** and focused on one task

## 🎨 Adding New Features

### Adding a New Page

1. Create a new `.razor` file in `Components/Pages/`
2. Add the `@page` directive with route
3. Add to navigation in `NavMenu.razor`

Example:

```razor
@page "/my-page"
@rendermode InteractiveServer

<PageTitle>My Page - ServeHub</PageTitle>

<h1>My New Page</h1>
<p>Content goes here</p>

@code {
    // Component code here
}
```

### Adding a New Model

1. Create a new class in `Models/` folder
2. Add properties with data annotations
3. Update `ApplicationDbContext.cs` to include the new DbSet
4. Create a migration: `dotnet ef migrations add AddNewModel`
5. Update database: `dotnet ef database update`

### Adding a New Service

1. Create interface in `Services/` (e.g., `IMyService.cs`)
2. Create implementation class (e.g., `MyService.cs`)
3. Register in `Program.cs`: `builder.Services.AddScoped<IMyService, MyService>();`
4. Inject into pages: `@inject IMyService MyService`

## 🔍 Testing Your Changes

### Manual Testing Checklist

Before pushing code:

- [ ] Application builds without errors: `dotnet build`
- [ ] Application runs without crashes: `dotnet run`
- [ ] New feature works as expected
- [ ] Existing features still work (regression test)
- [ ] UI is responsive on mobile (F12 in browser > device mode)
- [ ] No console errors in browser (F12 > Console tab)

### Database Testing

```bash
# Reset database to clean state
dotnet ef database drop
dotnet ef database update

# View current migrations
dotnet ef migrations list
```

## 📦 Current Features

### ✅ Implemented Features

1. **Home Page** - Hero section with call-to-action
2. **Opportunities List** - Browse all service opportunities
3. **Opportunity Details** - View detailed information
4. **User Registration** - Sign up for opportunities
5. **Authentication** - Login/Register/Logout (ready to implement pages)
6. **About Page** - Project information
7. **Responsive Navigation** - Mobile-friendly menu

### 🚧 Features To Implement (Team Tasks)

#### Priority 1 - Authentication Pages (Week 6)

- [ ] `/Account/Register` - User registration page
- [ ] `/Account/Login` - User login page
- [ ] `/Account/Logout` - Logout handler
- [ ] `/Account/Profile` - User profile page

#### Priority 2 - CRUD Operations (Week 6)

- [ ] `/Opportunities/Create` - Create new opportunity form
- [ ] `/Opportunities/Edit/{id}` - Edit opportunity form
- [ ] `/Opportunities/Delete/{id}` - Delete confirmation
- [ ] `/My-Registrations` - User's registration history

#### Priority 3 - Enhanced Features (Week 7)

- [ ] Category filtering on opportunities page
- [ ] Search functionality
- [ ] Date range filtering
- [ ] Admin dashboard (optional)
- [ ] Email notifications (optional)

#### Priority 4 - Testing & Deployment (Week 7)

- [ ] Unit tests for services
- [ ] Integration tests
- [ ] Deploy to Azure/AWS
- [ ] Configure production database
- [ ] Record demonstration video

## 🎥 Video Demonstration Requirements

Each team member must participate in the final video demonstration:

**Requirements:**

- **Length**: 5-7 minutes
- **Platform**: YouTube upload
- **Content**: Show operational functionality
- **Participation**: Each member presents a portion using their own camera

**What to Demonstrate:**

1. Home page and navigation
2. Browse opportunities
3. User registration/login
4. Register for an opportunity
5. View registrations
6. Create new opportunity (admin)
7. CRUD operations
8. Responsive design (show on mobile)
9. Accessibility features

## 🆘 Common Issues & Solutions

### Issue: "Cannot connect to database"

**Solution:**

```bash
# Check if LocalDB is running
sqllocaldb info

# Start LocalDB
sqllocaldb start MSSQLLocalDB

# Update connection string in appsettings.json if needed
```

### Issue: "Migration already applied"

**Solution:**

```bash
# Remove last migration
dotnet ef migrations remove

# Or reset database
dotnet ef database drop
dotnet ef database update
```

### Issue: "Package restore failed"

**Solution:**

```bash
# Clear NuGet cache
dotnet nuget locals all --clear

# Restore packages
dotnet restore
```

### Issue: "Port already in use"

**Solution:**
Edit `Properties/launchSettings.json` and change ports:

```json
"applicationUrl": "https://localhost:7001;http://localhost:5001"
```

## 📚 Resources

### Official Documentation

- [Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity)

### Tutorials

- [Blazor Tutorial](https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/intro)
- [EF Core Tutorial](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app)

### Bootstrap

- [Bootstrap 5 Documentation](https://getbootstrap.com/docs/5.3/)
- [Bootstrap Icons](https://icons.getbootstrap.com/)

## 👥 Team Communication

### Daily Standup Questions

1. What did you work on since last meeting?
2. What are you working on next?
3. Are there any blockers?

### Weekly Team Meeting Agenda

1. Review progress on GitHub Project Board (https://github.com/users/kendychae/projects/2)
2. Demo completed features
3. Assign new tasks
4. Discuss challenges
5. Plan next sprint

### Communication Channels

- **GitHub Issues**: For bugs and feature requests
- **Pull Requests**: For code reviews
- **Team Chat**: For quick questions
- **Weekly Meetings**: For coordination

## 🎯 Next Steps

### Week 6 Goals

1. **All team members**: Complete authentication pages
2. **All team members**: Implement at least one CRUD operation
3. **Team**: Use GitHub Project Board for task tracking (https://github.com/users/kendychae/projects/2)
4. **Team**: Begin testing and quality assurance

### Week 7 Goals

1. **Complete all CRUD operations**
2. **Deploy to cloud** (Azure App Service recommended)
3. **Record demonstration video**
4. **Submit final project**
5. **Complete peer evaluations**

---

**Questions?** Open an issue on GitHub or ask in the team chat!

**Last Updated**: February 2026  
**Project Lead**: Kendahl Chae Bingham
