# Team Task List - ServeHub Week 6-7

## 🎯 Current Status: Foundation Complete ✅

The project foundation is built and ready. All team members can now start implementing features.

---

## 📋 Required Tasks (To Complete Project)

### 🔐 Authentication & User Management (4-5 members)

#### Task 1: User Registration Page

**Assignee**: **********\_**********  
**File**: `Components/Pages/Account/Register.razor`  
**Route**: `/Account/Register`  
**Requirements**:

- Email field (validation)
- Password field (min 6 chars, uppercase, lowercase, digit)
- Confirm password field
- First name, Last name fields (optional)
- Submit button
- Link to login page
- Use `UserManager<ApplicationUser>` to create user
- Show success/error messages

**Time Estimate**: 4-6 hours

---

#### Task 2: User Login Page

**Assignee**: **********\_**********  
**File**: `Components/Pages/Account/Login.razor`  
**Route**: `/Account/Login`  
**Requirements**:

- Email field
- Password field
- "Remember me" checkbox
- Submit button
- Link to register page
- Use `SignInManager<ApplicationUser>` to authenticate
- Redirect to `/opportunities` on success
- Show error message on failure

**Time Estimate**: 3-4 hours

---

#### Task 3: Logout Functionality

**Assignee**: **********\_**********  
**File**: `Components/Pages/Account/Logout.razor`  
**Route**: `/Account/Logout`  
**Requirements**:

- Call `SignInManager.SignOutAsync()`
- Redirect to home page
- Show confirmation message (optional)

**Time Estimate**: 1-2 hours

---

#### Task 4: User Profile Page

**Assignee**: **********\_**********  
**File**: `Components/Pages/Account/Profile.razor`  
**Route**: `/Account/Profile`  
**Requirements**:

- Display user information
- Edit first name, last name
- Update profile image URL (optional)
- View registration history
- Save changes button
- Require authentication (`@attribute [Authorize]`)

**Time Estimate**: 3-4 hours

---

### 📝 CRUD Operations (4-5 members)

#### Task 5: Create Opportunity Page

**Assignee**: **********\_**********  
**File**: `Components/Pages/Opportunities/Create.razor`  
**Route**: `/opportunities/create`  
**Requirements**:

- Form with all opportunity fields:
  - Title (required, max 200 chars)
  - Description (required, max 2000 chars)
  - Location (required, max 300 chars)
  - Start Date/Time (required, future date)
  - End Date/Time (required, after start date)
  - Max Volunteers (required, 1-1000)
  - Category (optional dropdown)
  - Image URL (optional)
- Validation messages
- Submit button
- Use `IServiceOpportunityService.CreateOpportunityAsync()`
- Set `CreatedByUserId` to current user
- Redirect to opportunity details on success
- Require authentication

**Time Estimate**: 5-7 hours

---

#### Task 6: Edit Opportunity Page

**Assignee**: **********\_**********  
**File**: `Components/Pages/Opportunities/Edit.razor`  
**Route**: `/opportunities/edit/{id:int}`  
**Requirements**:

- Load existing opportunity by ID
- Pre-fill form with current values
- Allow updates to all fields
- Validation
- Save button, Cancel button
- Use `IServiceOpportunityService.UpdateOpportunityAsync()`
- Only allow creator to edit (check `CreatedByUserId`)
- Show 403 if not authorized
- Redirect to details on success

**Time Estimate**: 5-7 hours

---

#### Task 7: Delete Opportunity Confirmation

**Assignee**: **********\_**********  
**File**: `Components/Pages/Opportunities/Delete.razor`  
**Route**: `/opportunities/delete/{id:int}`  
**Requirements**:

- Load opportunity details
- Show confirmation message: "Are you sure you want to delete..."
- Delete button (red), Cancel button
- Use `IServiceOpportunityService.DeleteOpportunityAsync()`
- Only allow creator to delete
- Redirect to opportunities list on success
- Show error if opportunity has registrations (optional business rule)

**Time Estimate**: 3-4 hours

---

#### Task 8: My Registrations Page

**Assignee**: **********\_**********  
**File**: `Components/Pages/MyRegistrations.razor`  
**Route**: `/my-registrations`  
**Requirements**:

- Display current user's registrations
- Use `IRegistrationService.GetUserRegistrationsAsync()`
- Show opportunity details for each registration
- Separate upcoming and past events
- Cancel registration button for upcoming events
- Show registration date
- Require authentication
- Empty state message if no registrations

**Time Estimate**: 4-5 hours

---

### 🎨 Enhancement Features (2-3 members)

#### Task 9: Category Filter on Opportunities Page

**Assignee**: **********\_**********  
**File**: `Components/Pages/Opportunities.razor` (update existing)  
**Requirements**:

- Add dropdown filter above opportunities list
- Use `IServiceOpportunityService.GetCategoriesAsync()`
- Filter opportunities by selected category
- "All Categories" option
- Use `IServiceOpportunityService.GetOpportunitiesByCategoryAsync()`

**Time Estimate**: 2-3 hours

---

#### Task 10: Search Functionality

**Assignee**: **********\_**********  
**File**: `Components/Pages/Opportunities.razor` (update existing)  
**Requirements**:

- Add search box
- Search by title, description, location
- Real-time filtering (as user types)
- Clear search button
- Show count of results

**Time Estimate**: 3-4 hours

---

#### Task 11: Date Range Filter

**Assignee**: **********\_**********  
**File**: `Components/Pages/Opportunities.razor` (update existing)  
**Requirements**:

- Add start date and end date input
- Filter opportunities between dates
- Show only future opportunities by default
- Include "Show past opportunities" checkbox

**Time Estimate**: 2-3 hours

---

### 🧪 Testing & Quality (2 members)

#### Task 12: Unit Tests

**Assignee**: **********\_**********  
**File**: Create new test project  
**Requirements**:

- Create xUnit test project
- Test `ServiceOpportunityService` methods
- Test `RegistrationService` methods
- Mock `ApplicationDbContext`
- Aim for >70% code coverage

**Time Estimate**: 6-8 hours

---

#### Task 13: Integration Tests

**Assignee**: **********\_**********  
**File**: Add to test project  
**Requirements**:

- Test database operations
- Test authentication flows
- Use in-memory database
- Test CRUD workflows end-to-end

**Time Estimate**: 4-6 hours

---

### 🚀 Deployment & Documentation (2 members)

#### Task 14: Azure Deployment

**Assignee**: **********\_**********  
**Requirements**:

- Create Azure App Service
- Configure Azure SQL Database
- Set up connection strings
- Deploy application
- Test production site
- Document deployment URL

**Time Estimate**: 4-6 hours

---

#### Task 15: Video Demonstration

**Assignee**: ALL TEAM MEMBERS (each presents a portion)  
**Requirements**:

- Record 5-7 minute video
- Each member uses own camera
- Demonstrate all features:
  - Home page
  - Browse opportunities
  - Register/Login
  - Create opportunity
  - Register for opportunity
  - Edit/Delete opportunity
  - My registrations
  - Responsive design (mobile view)
- Upload to YouTube
- Add link to README

**Time Estimate**: 2-3 hours per person (planning + recording)

---

## 📅 Recommended Schedule

### Week 6 (Current Week)

- **Monday-Tuesday**: Set up development environments, assign tasks
- **Wednesday-Friday**: Work on authentication + CRUD pages
- **Weekend**: Complete assigned features, test locally

### Week 7 (Final Week)

- **Monday-Tuesday**: Complete remaining features, fix bugs
- **Wednesday**: Deploy to cloud, final testing
- **Thursday**: Record video demonstration
- **Friday**: Submit project, complete peer evaluations

---

## 🎯 Task Assignment Guidelines

### How to Claim a Task

1. Add your name next to "Assignee" above
2. Create a branch: `git checkout -b feature/task-name`
3. Update this file and commit: `git commit -am "Claimed Task X"`
4. Push: `git push origin feature/task-name`
5. Open draft PR to show you're working on it

### Task Dependencies

- Tasks 1-4 (Authentication) can be done in parallel
- Tasks 5-8 (CRUD) require authentication to be complete
- Tasks 9-11 (Enhancements) can be done in parallel with CRUD
- Task 12-13 (Testing) should be done after core features
- Task 14 (Deployment) should be done in Week 7
- Task 15 (Video) must be done last

### Required Skills by Task

**Beginner-Friendly Tasks:**

- Task 3 (Logout) - Simple, good starter
- Task 9 (Category Filter) - Builds on existing page
- Task 11 (Date Filter) - Similar to Task 9

**Intermediate Tasks:**

- Task 1, 2 (Register/Login) - Forms with validation
- Task 4 (Profile) - Data editing
- Task 7 (Delete) - Simple confirmation
- Task 10 (Search) - Client-side filtering

**Advanced Tasks:**

- Task 5, 6 (Create/Edit) - Complex forms
- Task 8 (My Registrations) - Multiple queries
- Task 12, 13 (Testing) - Requires testing knowledge
- Task 14 (Deployment) - Azure experience helpful

---

## ✅ Definition of Done

A task is complete when:

- [ ] Code is written and commented
- [ ] Feature works without errors
- [ ] Tested locally with `dotnet run`
- [ ] Code is pushed to feature branch
- [ ] Pull request created
- [ ] PR reviewed by at least one team member
- [ ] Merged to main branch
- [ ] Documented (if needed)

---

## 🆘 Getting Help

### Stuck on a Task?

1. **Check documentation**:
   - [docs/GETTING_STARTED.md](GETTING_STARTED.md)
   - [docs/PROJECT_GUIDE.md](PROJECT_GUIDE.md)
   - [docs/QUICK_REFERENCE.md](QUICK_REFERENCE.md)

2. **Search existing code**:
   - Look at similar components already built
   - `Opportunities.razor` and `OpportunityDetails.razor` are good examples

3. **Ask the team**:
   - Open a GitHub issue with your question
   - Ask in team chat
   - Request help in weekly meeting

4. **Online resources**:
   - [Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
   - [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity)
   - [Stack Overflow](https://stackoverflow.com/questions/tagged/blazor)

---

## 📊 Progress Tracking

### Overall Progress: 40% Complete

- [x] Project structure created
- [x] Database models defined
- [x] Services implemented
- [x] Home page complete
- [x] Opportunities list complete
- [x] Opportunity details complete
- [x] About page complete
- [ ] Authentication pages (0/4)
- [ ] CRUD pages (0/4)
- [ ] Enhancements (0/3)
- [ ] Testing (0/2)
- [ ] Deployment (0/1)
- [ ] Video demonstration (0/1)

**Update this section as tasks are completed!**

---

## 🎉 Team Collaboration Tips

1. **Communicate frequently** - Don't wait until the deadline
2. **Test your changes** - Run `dotnet run` before pushing
3. **Write clear commit messages** - Describe what you changed
4. **Review others' PRs** - Help catch bugs early
5. **Ask for help** - Don't struggle alone for hours
6. **Document as you go** - Add comments to complex code
7. **Stay organized** - Use Trello board for task tracking

---

**Last Updated**: February 1, 2026  
**Next Update**: After task assignments  
**Questions?** Contact Kendahl Chae Bingham or open a GitHub issue
