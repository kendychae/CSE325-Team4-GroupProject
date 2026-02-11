# Week 7 Update - February 11, 2026

## Changes Made

### 1. Database Seeding for Video Demo
- **Created**: `Data/DatabaseSeeder.cs`
- **Purpose**: Seeds the database with 10 diverse service opportunities and 3 demo users
- **Demo Users Created**:
  - demo@servehub.com (Password: Demo123!)
  - volunteer@servehub.com (Password: Demo123!)
  - organizer@servehub.com (Password: Demo123!)

- **Mock Opportunities Include**:
  - Community Park Cleanup (Phoenix - Environment)
  - Food Bank Sorting and Distribution (Tempe - Hunger Relief)
  - Senior Center Tech Help Day (Mesa - Education)
  - Animal Shelter Dog Walking (Phoenix - Animals)
  - Youth Reading Program Tutors (Scottsdale - Education)
  - Habitat for Humanity Build Day (Gilbert - Community Development)
  - Hospital Patient Companion Program (Phoenix - Healthcare)
  - River Cleanup Initiative (Mesa - Environment)
  - Homeless Shelter Meal Service (Phoenix - Hunger Relief)
  - Youth Mentorship Program Orientation (Chandler - Youth Development)

- **Updated**: `Program.cs` to call the seeder after migrations

### 2. Fixed Filtering Logic
- **Updated**: `Components/Pages/Opportunities.razor`
- **Issues Fixed**:
  - Removed inconsistent behavior where category filter reloaded from service but other filters worked client-side
  - Now all filters work together consistently using client-side filtering
  - Categories are extracted from loaded opportunities instead of separate service call
  - Date filters now use `.Date` property to properly compare dates (not date-time)
  - Simplified `ClearFilters()` method - no longer async

- **Filtering Features**:
  - ✅ Real-time text search (title and description)
  - ✅ Location filter
  - ✅ Category dropdown filter
  - ✅ Start date range filters (from and to)
  - ✅ Results count display
  - ✅ Clear filters button

### 3. Added My Registrations Page
- **Created**: `Components/Pages/MyRegistrations.razor`
- **Features**:
  - Shows upcoming and past volunteer registrations
  - Separates events into "Upcoming Events" and "Past Events"
  - Allows canceling upcoming registrations
  - Shows registration dates
  - Links to opportunity details
  - Requires authentication
  - Empty state message when no registrations exist

## Week 7 Requirements Checklist

### ✅ Core Requirements Met
- [x] **User Authentication**
  - Login page (`Components/Pages/Account/Login.razor`)
  - Register page (`Components/Pages/Account/Register.razor`)
  - Logout functionality (`Components/Pages/Account/Logout.razor`)
  - Profile page (`Components/Pages/Account/Profile.razor`)

- [x] **CRUD Operations**
  - Create opportunity (`Components/Pages/OpportunityManagement/CreateOpportunity.razor`)
  - Read/View opportunities (`Components/Pages/Opportunities.razor`, `OpportunityDetails.razor`)
  - Update opportunity (`Components/Pages/OpportunityManagement/EditOpportunity.razor`)
  - Delete opportunity (`Components/Pages/OpportunityManagement/Delete.razor`)
  - Dashboard for managing own opportunities

- [x] **Additional Features**
  - Search functionality (text search)
  - Category filter
  - Location filter
  - Date range filters
  - My Registrations page
  - Opportunity registration system

- [x] **Cloud Deployment**
  - Azure SQL Database configuration in `appsettings.json`
  - Connection string: `servehub-sqlserver.database.windows.net`
  - Ready for Azure App Service deployment

- [x] **Mock Data for Video**
  - Database seeder with 10 diverse opportunities
  - 3 demo user accounts ready to use
  - Categories include: Environment, Hunger Relief, Education, Animals, Community Development, Healthcare, Youth Development

## Testing Checklist

### Before Recording Video
1. **Delete existing database**: `Remove-Item ServeHub.db`
2. **Run application**: `dotnet run --project ServeHub.csproj`
3. **Verify seeding**: Check console for "Successfully seeded X service opportunities!"
4. **Test demo login**: Use demo@servehub.com / Demo123!

### Features to Demonstrate in Video
Each team member should demonstrate different features:

**Member 1 - Home & Browse**
- [ ] Home page introduction
- [ ] Navigate to Opportunities page
- [ ] Show all 10 seeded opportunities
- [ ] Test search filter (type "park" or "food")
- [ ] Test location filter (type "Phoenix" or "Tempe")
- [ ] Test category filter (select "Environment" or "Education")
- [ ] Test date filters
- [ ] Show results count updating
- [ ] Test "Clear Filters" button

**Member 2 - Authentication**
- [ ] Register new account
- [ ] Login with demo account
- [ ] Show profile page
- [ ] Navigate to My Registrations (empty state)
- [ ] Logout

**Member 3 - Opportunity Details & Registration**
- [ ] Login with demo account
- [ ] Click on an opportunity
- [ ] Show opportunity details page
- [ ] Register for opportunity
- [ ] Go to My Registrations
- [ ] Show registered opportunity
- [ ] Cancel registration

**Member 4 - Create/Manage Opportunities**
- [ ] Login with demo account
- [ ] Go to Dashboard
- [ ] Create new opportunity
  - Title: "Test Volunteer Event"
  - Description: "This is a test event for demonstration"
  - Location: "Scottsdale, AZ"
  - Start Date: Future date
  - End Date: After start date
  - Max Volunteers: 20
- [ ] View created opportunity in dashboard
- [ ] Edit opportunity
- [ ] Delete opportunity

**Member 5 - Responsive Design & Wrap-up**
- [ ] Show mobile view (resize browser or use dev tools)
- [ ] Navigate through pages on mobile
- [ ] Show responsive navigation menu
- [ ] Demonstrate mobile-friendly cards
- [ ] Wrap up and show About page

## Known Issues & Notes

### Database Seeding
- Seeding only runs if database is empty (`!context.ServiceOpportunities.Any()`)
- To reseed, delete `ServeHub.db` file before running
- Images use Unsplash URLs - require internet connection to display

### Azure Deployment
- Azure SQL connection string is commented out in `appsettings.json`
- Switch to Azure SQL by uncommenting `_AzureConnection` line
- Ensure Azure SQL firewall allows your IP
- Database migrations run automatically on startup

### Filters
- All filtering is client-side for better performance
- Date filters compare dates (not date-time) for more intuitive behavior
- Search includes both title and description

## Files Changed

### New Files
1. `Data/DatabaseSeeder.cs` - Database seeding logic
2. `Components/Pages/MyRegistrations.razor` - User registrations page
3. `docs/Week7_Final_Updates.md` - This file

### Modified Files
1. `Program.cs` - Added seeder call
2. `Components/Pages/Opportunities.razor` - Fixed filtering logic

## Next Steps

### Before Merging to Main
1. Test all features locally
2. Verify filtering works correctly
3. Confirm seeding creates 10 opportunities
4. Ensure demo users can login
5. Check My Registrations page works

### For Video Recording
1. Delete database: `Remove-Item ServeHub.db`
2. Run fresh: `dotnet run`
3. Each member records their section
4. Combine and upload to YouTube
5. Update README with video link

### For Final Submission
1. Merge kendahl-bingham to main
2. Push to GitHub
3. Deploy to Azure (if not already deployed)
4. Test deployed site
5. Submit Canvas assignment with:
   - GitHub repo link
   - Azure deployment link
   - YouTube video link
   - Trello board link

## Demo User Credentials

For video demonstration, use these accounts:

```
Email: demo@servehub.com
Password: Demo123!

Email: volunteer@servehub.com
Password: Demo123!

Email: organizer@servehub.com
Password: Demo123!
```

## Architecture Notes

### Why Client-Side Filtering?
- Faster user experience (no server round-trips)
- Filters work together seamlessly
- Simpler code - easier to maintain
- All opportunities are loaded once

### Data Flow
1. Load all active opportunities on page init
2. Extract categories from loaded data
3. Apply all filters in memory using LINQ
4. UI updates reactively with `@bind:event="oninput"`

## Questions or Issues?

Contact: Kendahl Chae Bingham
Branch: kendahl-bingham
Last Updated: February 11, 2026
