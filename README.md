# CSE 325 - Team 4 Group Project: ServeHub

## .NET Blazor Web Application - Volunteer Service Portal

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Blazor](https://img.shields.io/badge/Blazor-Server-512BD4?logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)

## 📋 Project Overview

ServeHub is a comprehensive volunteer management web application built with Blazor Server and ASP.NET Core. This project fulfills the requirements for CSE 325 - .NET Software Development at Brigham Young University-Idaho (Winter 2026).

**Project Status:** ✅ Active Development - Fully Restructured for W7 Requirements

### 🎯 Application Purpose

ServeHub connects volunteers with meaningful service opportunities in their communities. The platform enables:
- Organizations to post and manage volunteer opportunities
- Volunteers to discover, register for, and track service activities
- Community engagement through accessible and user-friendly volunteer coordination

## 👥 Team Members - Team 4

- **Kendahl Chae Bingham** - Team Lead
- **Adetokunbo Olutola Osibo**
- **Ange Junior Gohouri**
- **Boitumelo Hebert Meletse**
- **Brenden Taylor Lyon**
- **Curtis Guelable Siahe**
- **Djimy Francillon**
- **Gabriel Enrique Torrejon Aguilera**
- **Iyen Samuel Evbosaru**
- **Judy Hanson**
- **Maxwell Balla Nvani**
- **Michael Effiong Akpan**
- **Shayla Foley**

## ✅ W7 Requirements Compliance

This project fully meets all Week 7 Group Project specifications:

### Core Requirements Met

| Requirement | Status | Implementation |
|------------|--------|----------------|
| **Blazor Web Application** | ✅ Complete | Monolithic Blazor Server architecture |
| **User Authentication** | ✅ Complete | ASP.NET Core Identity with secure registration/login |
| **CRUD Functionality** | ✅ Complete | Full Create, Read, Update, Delete for service opportunities |
| **Database Integration** | ✅ Complete | Entity Framework Core with SQL Server |
| **Performance Optimized** | ✅ Complete | Server-side rendering, efficient data queries |
| **Responsive Design** | ✅ Complete | Mobile-first Bootstrap 5 implementation |
| **Accessibility** | ✅ Complete | WCAG 2.1 Level AA compliant markup |
| **GitHub Repository** | ✅ Complete | Version control with collaborative workflow |
| **Documentation** | ✅ Complete | Comprehensive README and getting started guide |
| **Cloud Deployment Ready** | ✅ Ready | Configured for Azure/AWS deployment |

### Design Standards

- ✅ **Performance**: Optimized server-side rendering, minimal network overhead
- ✅ **Validation**: HTML5 and CSS validation, model validation
- ✅ **Accessibility**: Semantic HTML, ARIA labels, keyboard navigation
- ✅ **Usability**: Intuitive navigation, responsive across all devices
- ✅ **Branding**: Consistent color scheme, typography, and layout
- ✅ **Navigation**: Clear hierarchy with logical menu structure

## 🚀 Key Features

### 1. Service Opportunity Management
- **Create Opportunities**: Organizations can post volunteer opportunities with details
- **Browse & Search**: Users can discover opportunities by category, date, and location
- **View Details**: Comprehensive information about each opportunity
- **Update & Delete**: Opportunity creators can manage their postings

### 2. Volunteer Registration System
- **Easy Registration**: One-click registration for opportunities
- **Capacity Management**: Automatic tracking of volunteer spots
- **Registration History**: Users can view their past and upcoming commitments
- **Cancellation Support**: Ability to cancel registrations when needed

### 3. User Authentication & Security
- **Secure Registration**: ASP.NET Core Identity with password requirements
- **Login System**: Persistent sessions with cookie authentication
- **Role-Based Access**: Protected routes for authenticated users
- **Profile Management**: User account information and settings

### 4. Modern User Interface
- **Responsive Design**: Optimized for desktop, tablet, and mobile devices
- **Bootstrap 5**: Professional styling with modern components
- **Interactive Components**: Real-time updates without page refreshes
- **Accessible Navigation**: Screen reader friendly with keyboard support

## 🛠️ Technology Stack

- **Framework**: .NET 10.0
- **UI**: Blazor Server with Interactive Server rendering
- **Authentication**: ASP.NET Core Identity
- **Database**: Entity Framework Core with SQL Server
- **ORM**: Entity Framework Core
- **Styling**: Bootstrap 5 + Custom CSS
- **Icons**: Bootstrap Icons
- **Architecture**: Monolithic Blazor Server application

## 📁 Project Structure

```
ServeHub/
├── Components/
│   ├── Layout/              # Application layouts and navigation
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   └── Pages/               # Razor pages/components
│       ├── Home.razor
│       ├── Opportunities.razor
│       ├── OpportunityDetails.razor
│       └── About.razor
├── Data/                    # Database context and configuration
│   ├── ApplicationDbContext.cs
│   └── ApplicationUser.cs
├── Models/                  # Domain models
│   ├── ServiceOpportunity.cs
│   └── ServiceRegistration.cs
├── Services/                # Business logic services
│   ├── IServiceOpportunityService.cs
│   ├── ServiceOpportunityService.cs
│   ├── IRegistrationService.cs
│   └── RegistrationService.cs
├── wwwroot/                 # Static assets
│   ├── css/
│   ├── js/
│   └── lib/
├── docs/                    # Project documentation
│   ├── GETTING_STARTED.md
│   ├── Week2_Team_Submission.md
│   ├── Week3_Team_Submission.md
│   ├── Week4_Team_Submission.md
│   └── Week5_Team_Submission.md
├── Program.cs              # Application startup
├── appsettings.json        # Configuration
└── ServeHub.csproj         # Project file
```

## 🚀 Getting Started

### Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) (included with Visual Studio)
- [Git](https://git-scm.com/downloads)

### Quick Start

1. **Clone the Repository**
   ```bash
   git clone https://github.com/kendychae/CSE325-Team4-GroupProject.git
   cd CSE325-Team4-GroupProject
   ```

2. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

3. **Setup Database**
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Run the Application**
   ```bash
   dotnet run
   ```

5. **Open in Browser**
   - Navigate to `https://localhost:5001`

For detailed setup instructions, see [GETTING_STARTED.md](docs/GETTING_STARTED.md).

## 📚 Documentation

- **[Getting Started Guide](docs/GETTING_STARTED.md)** - Complete setup and usage instructions
- **[Contributing Guidelines](CONTRIBUTING.md)** - How to contribute to the project
- **[Code of Conduct](CODE_OF_CONDUCT.md)** - Community standards and expectations

### Weekly Submissions

- [Week 2 Submission](docs/Week2_Team_Submission.md) - Initial planning and brainstorming
- [Week 3 Submission](docs/Week3_Team_Submission.md) - Architecture and design decisions
- [Week 4 Submission](docs/Week4_Team_Submission.md) - Development progress checkpoint
- [Week 5 Submission](docs/Week5_Team_Submission.md) - Current status and updates

## 🔧 Development

### Running Locally

```bash
# Development with hot reload
dotnet watch run

# Production build
dotnet build -c Release
dotnet run -c Release
```

### Database Migrations

```bash
# Add a new migration
dotnet ef migrations add MigrationName

# Update database
dotnet ef database update

# Remove last migration
dotnet ef migrations remove
```

### Testing

```bash
# Run tests
dotnet test

# Run with coverage
dotnet test --collect:"XPlat Code Coverage"
```

## 🌐 Deployment

The application is configured for deployment to:
- **Azure App Service** (Recommended for .NET applications)
- **AWS Elastic Beanstalk**
- **Docker containers**
- **IIS on Windows Server**

Deployment documentation will be provided in Week 7.

## 📊 Project Management

- **GitHub Repository**: [CSE325-Team4-GroupProject](https://github.com/kendychae/CSE325-Team4-GroupProject)
- **Trello Board**: [Link to be added]
- **Communication**: Microsoft Teams / Discord (Course Channel)

## 🤝 Contributing

We welcome contributions from all team members! Please follow these steps:

1. Create a new branch for your feature: `git checkout -b feature/your-feature-name`
2. Make your changes and commit: `git commit -m "Description of changes"`
3. Push to GitHub: `git push origin feature/your-feature-name`
4. Create a Pull Request for review

See [CONTRIBUTING.md](CONTRIBUTING.md) for detailed guidelines.

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🎓 Academic Information

**Course**: CSE 325 - .NET Software Development  
**Institution**: Brigham Young University-Idaho  
**Semester**: Winter 2026  
**Instructor**: [Instructor Name]

## 📞 Contact

For questions or support:
- Open an issue on [GitHub](https://github.com/kendychae/CSE325-Team4-GroupProject/issues)
- Contact team lead: Kendahl Chae Bingham
- Course communication channels

## 🙏 Acknowledgments

- BYU-Idaho CSE Department for project guidance
- Microsoft for excellent .NET and Blazor documentation
- All Team 4 members for their dedication and contributions
- Open source community for libraries and tools

---

**Last Updated**: February 2026  
**Version**: 2.0.0 - Monolithic Blazor Architecture  
**Status**: Active Development
- If you encounter build errors, try `dotnet clean` then `dotnet build`.
- For dependency issues, run `dotnet restore` again.

#### 8. Additional Resources

- See the `docs/` folder for weekly submissions and architecture notes.
- Ask in the team chat or open an issue for help.

---

## 👤 New Developer Quick Start

1. Clone the repo and open in your IDE
2. Restore dependencies and build the project
3. Run the UI and API projects as needed
4. Review the `README.md` and `docs/` for project context
5. Use the GitHub Project Board for tasks
6. Follow the branching and PR workflow
7. Reach out to the team for onboarding help

## 📁 Project Structure

```
CSE325-Team4-GroupProject/
├── docs/               # Documentation and weekly submissions
├── src/                # Source code (to be added)
├── tests/              # Unit and integration tests (to be added)
├── .gitignore          # Git ignore file
└── README.md           # This file
```

## 🔧 Development Workflow

### Branching Strategy

- `main` - Production-ready code
- `develop` - Integration branch for features
- `feature/[feature-name]` - Individual feature branches
- `hotfix/[issue]` - Critical bug fixes

### Contributing

1. Create a feature branch from `develop`
2. Make your changes with descriptive commit messages
3. Test your changes thoroughly
4. Submit a pull request to `develop`
5. Wait for code review and approval

## 📊 Project Management

We use GitHub Projects for project management and task tracking.

**GitHub Project Board:** https://github.com/users/kendychae/projects/2/views/1

## 📝 Weekly Submissions

- [Week 2 Submission](docs/Week2_Team_Submission.md) - Planning & Repository Setup
- [Week 3 Submission](docs/Week3_Team_Submission.md) - Project Proposal & Requirements
- [Week 4 Submission](docs/Week4_Team_Submission.md) - Project Checkpoint & Initialization

## 🧪 Testing

We use .NET's built-in testing tools for unit and integration tests. All test projects should be placed in the `tests/` directory.

### How to Run Tests

1. Restore dependencies (if not already done):
   ```
   dotnet restore
   ```
2. Run all tests in the solution:
   ```
   dotnet test
   ```
3. To run tests for a specific project:
   ```
   dotnet test path/to/YourTestProject.csproj
   ```

### Writing Tests

- Add new test projects to the `tests/` folder.
- Use xUnit, NUnit, or MSTest (xUnit recommended for .NET projects).
- Place your test classes and methods following .NET conventions.

### Guidelines

- Write tests for all new features and bug fixes.
- Use descriptive names for test methods.
- Run all tests before submitting a pull request.

See the [Microsoft Testing Documentation](https://docs.microsoft.com/en-us/dotnet/core/testing/) for more details.

## 📚 Documentation

Additional documentation can be found in the `docs/` directory:

- Project proposals and brainstorming notes
- Architecture decisions
- API documentation
- User guides

## 🤝 Code of Conduct

All team members are expected to:

- Communicate respectfully and professionally
- Meet deadlines and commitments
- Participate actively in team meetings
- Provide constructive feedback
- Help and support fellow team members

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- BYU-Idaho CSE Department
- Course Instructor and TAs
- All Team 4 members for their dedication and collaboration

## 📞 Contact

For questions or concerns about this project, please contact the current week's team leader or reach out through our team communication channels.

---

**Course:** CSE 325 - .NET Software Development  
**Institution:** Brigham Young University-Idaho  
**Semester:** Winter 2026  
**Team:** Team 4
