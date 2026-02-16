# Week 7 Video Guide - ServeHub (5-7 minutes)

## Setup Before Recording

1. Delete database: `Remove-Item ServeHub.db`
2. Run: `dotnet run --project ServeHub.csproj`
3. Open: http://localhost:5000

## Mock Data - Demo Accounts

**All accounts use password:** `Demo123!`

- `demo@servehub.com` - Demo User
- `volunteer@servehub.com` - Volunteer User
- `organizer@servehub.com` - Event Organizer

---

## Team Member Assignments & Scripts

### 1. Ange Junior Gohouri - GitHub Project Board & Repository (45s)

**What to show:**

- Open GitHub repo in browser: https://github.com/kendychae/CSE325-Team4-GroupProject
- Show README with project description
- Navigate to Project Board: https://github.com/users/kendychae/projects/2
- Show different columns (Backlog, In Progress, Done)
- Mention total commits and contributors

**Script:**

> "Hi, I'm Ange. I'll walk you through our GitHub organization. Our ServeHub repository contains all our source code, with clear documentation in the README. We've been using a GitHub Project board to track our tasks throughout development. As you can see, we have tasks organized in columns showing our workflow from backlog through completion. Our team of 10 has made consistent commits throughout the weeks, demonstrating good collaboration and version control practices."

---

### 2. Maxwell Balla Nvani - Code Coverage & Blazor Implementation (60s)

**What to show:**

- Open project in VS Code/IDE
- Show folder structure (Components/, Data/, Services/, Models/)
- Point out clean organization
- Show one Blazor component (e.g., Opportunities.razor) with @page, @code sections
- Mention separation of concerns (Services, Models, Data layers)

**Script:**

> "I'm Maxwell, and I'll show you our code structure. ServeHub is built with Blazor Server in .NET 8. Our project follows best practices with clear separation - Components for our UI pages, Services for business logic, Models for data structures, and Data for database context. Each Blazor component uses the @page directive for routing and @code blocks for logic. For example, our Opportunities page uses dependency injection to access the OpportunityService. This clean architecture makes our code maintainable and testable."

---

### 3. Iyen Samuel Evbosaru - Error Handling (45s)

**What to show:**

- Try to create opportunity without required fields - show validation errors
- Show 404 page (navigate to /nonexistent-page)
- Try to access protected page without login - show redirect
- Show loading states and error messages

**Script:**

> "I'm Iyen, demonstrating our error handling. Watch what happens when I try to create an opportunity without filling required fields - we get clear validation messages. If I navigate to a non-existent page, our custom 404 page appears. Trying to access protected pages without authentication redirects you to login. Throughout the app, we display loading spinners during data fetches and show user-friendly error messages when operations fail. These features ensure a smooth, professional user experience."

---

### 4. Gabriel Enrique Torrejon Aguilera - User Experience Demo Part 1 (60s)

**What to show:**

- Start on Home page - show clean design
- Navigate to Opportunities page
- Show search functionality (type "park")
- Filter by location (type "Phoenix")
- Filter by category (select "Environment")
- Apply date filters
- Show results count updating
- Clear filters button

**Script:**

> "I'm Gabriel, and I'll demonstrate our user experience. Our home page welcomes users with a clean, professional design. On the Opportunities page, you can see all available volunteer events. Watch how the search works in real-time as I type 'park' - the results filter instantly. I can also filter by location like Phoenix, select categories like Environment, and set date ranges. The results count updates automatically. When I'm done, the Clear Filters button resets everything. This makes finding the right volunteer opportunity quick and intuitive."

---

### 5. Adetokunbo Olutola Osibo - User Account Setup (50s)

**What to show:**

- Click Login
- Show login form
- Login with demo@servehub.com / Demo123!
- Show navigation changes (My Registrations, Dashboard appear)
- Click Profile - show user information
- Logout

**Script:**

> "I'm Tokunbo, showing our authentication system. Clicking Login brings up our secure login form. I'll sign in with our demo account. Once logged in, notice the navigation changes - we now see My Registrations and Dashboard links. The Profile page displays my account information. Our authentication is built on ASP.NET Core Identity, providing secure password hashing and session management. Logging out returns the app to the public view. This ensures only authorized users can create and manage opportunities."

---

### 6. Shayla Foley - Filter Functionality Deep Dive (50s)

**What to show:**

- On Opportunities page, demonstrate each filter working:
  - Search by title: type "food" - show results
  - Search by description keywords
  - Location filter: "Tempe"
  - Category filter: "Education"
  - Date range: set start date to next month
- Show all filters working together
- Clear and reapply different combinations

**Script:**

> "I'm Shayla, and I worked on the filtering functionality. Our filter system is powerful and works client-side for fast performance. The search filter looks through both titles and descriptions - watch as I type 'food'. The location filter helps you find local opportunities. Categories let you focus on causes you care about. Date filters show opportunities in your timeframe. All these filters work together - I can search for 'youth' education opportunities in Tempe starting next month. The real-time updates and results count make it easy to find exactly what you're looking for."

--- ### 7. Boitumelo Hebert Meletse - Consistent Branding & Navigation (45s)

**What to show:**

- Navigate through different pages (Home, Opportunities, About)
- Point out consistent header/nav bar
- Show footer on all pages
- Demonstrate responsive menu collapse on narrow window
- Show consistent color scheme and buttons

**Script:**

> "I'm Boitumelo, and I'll highlight our consistent branding. Notice how our navigation bar stays consistent across all pages - same logo, same menu structure. Our color scheme uses blue and white throughout, creating a cohesive professional look. Watch what happens when I resize the window - the menu collapses into a mobile-friendly hamburger menu. Every page has the same footer with links and information. Button styles are consistent whether you're registering, creating, or editing. This consistency makes ServeHub feel polished and professional."

---

### 8. Brenden Taylor Lyon - WCAG 2.1 Level AA Compliance (50s)

**What to show:**

- Show form labels and aria-labels in browser inspector
- Demonstrate keyboard navigation (Tab through forms)
- Show color contrast (inspect with dev tools)
- Point out alt text on images
- Show focus indicators on interactive elements

**Script:**

> "I'm Brenden, and I ensured our accessibility compliance. Every form input has proper labels - watch as I tab through this form with keyboard only. Our color contrast meets WCAG AA standards - you can verify this in dev tools. All images have descriptive alt text for screen readers. Interactive elements show clear focus indicators. Semantic HTML helps assistive technologies understand page structure. We've added ARIA labels where needed, like on our search and filter inputs. These features make ServeHub accessible to all users, regardless of ability."

---

### 9. Kendahl Chae Bingham - Documentation & CRUD Demo (60s)

**What to show:**

- Login with demo account
- Navigate to Dashboard
- Create new opportunity: "River Cleanup", "Help clean the Salt River", Scottsdale, tomorrow 9am-12pm, 10 volunteers
- Click to view created opportunity
- Edit: change Max Volunteers to 15
- Save and verify
- Delete the opportunity
- Confirm deletion

**Script:**

> "I'm Kendahl, and I'll demonstrate our full CRUD operations while highlighting documentation. Throughout development, I maintained documentation in our docs folder covering setup, migrations, and team tasks. Now for CRUD - logged in users see a Dashboard. I'll create a River Cleanup opportunity with all required details. After creation, I can view the full details. Need to allow more volunteers? I'll edit and increase the max to 15. Changes save immediately. If an opportunity gets cancelled, organizers can delete it with confirmation. This demonstrates complete Create, Read, Update, Delete functionality for service opportunities."

---

## Closing Statement (10s)

**Any team member:**

> "Thank you for watching. ServeHub demonstrates a complete Blazor web application with authentication, full CRUD operations, real-time filtering, and professional UX. Our code is well-organized, accessible, and ready for production deployment on Azure."

---

## Links for Submission

- **Repo**: https://github.com/kendychae/CSE325-Team4-GroupProject
- **Project Board**: https://github.com/users/kendychae/projects/2
- **Deployed Site**: http://servehub-app-b3fac9a8h5cybrfr.spaincentral-01.azurewebsites.net/
- **Video**: [Insert Zoom/Teams Recording Link]
