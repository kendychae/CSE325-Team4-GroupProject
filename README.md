# CSE 325 - Team 4 Group Project

## .NET Software Development - Blazor Application

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Blazor](https://img.shields.io/badge/Blazor-512BD4?logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)

## 📋 Project Overview

This repository contains the collaborative group project for CSE 325 - .NET Software Development at Brigham Young University-Idaho. Our team is developing a web/mobile application using the .NET Blazor framework throughout the Winter 2026 semester.

**Project Status:** Planning & Brainstorming Phase (Week 2)

## 👥 Team Members - Team 4

- **Kendahl Chae Bingham**
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

## 🎯 Project Goals

- Design and develop a professional .NET Blazor web/mobile application
- Demonstrate proficiency in the .NET development ecosystem
- Apply software engineering best practices
- Collaborate effectively as a development team
- Create a portfolio-worthy project for future employment opportunities

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/downloads)

### Cloning the Repository

```bash
git clone https://github.com/kendychae/CSE325-Team4-GroupProject.git
cd CSE325-Team4-GroupProject
```

### Initial Setup & Onboarding

#### 1. Clone the Repository

```
git clone https://github.com/kendychae/CSE325-Team4-GroupProject.git
cd CSE325-Team4-GroupProject
```

#### 2. Open the Solution

- In **Visual Studio 2022**: Open the `ServiceActsAdminUI/ServiceActsAdminUI.csproj` file or the solution file if present.
- In **VS Code**: Open the project folder. Install the C# Dev Kit extension if prompted.

#### 3. Restore Dependencies

Run the following command in the root directory or use Visual Studio's restore option:

```
dotnet restore ServiceActsAdminUI/ServiceActsAdminUI.csproj
```

#### 4. Build & Run the Application

```
dotnet run --project ServiceActsAdminUI/ServiceActsAdminUI.csproj
```

The app should be available at `https://localhost:5001` or the port specified in the output.

#### 5. API Project (if present)

If you need to run the API separately:

```
dotnet run --project ServiceActsApi/ServiceActsApi.csproj
```

#### 6. Making Changes

- Create a new branch from `develop` for your feature or fix.
- Commit changes with clear messages.
- Push your branch and open a Pull Request to `develop`.

#### 7. Troubleshooting

- Ensure you have the correct .NET SDK version installed.
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

## 🧪 Testing

Testing guidelines and instructions will be added as the project develops.

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
