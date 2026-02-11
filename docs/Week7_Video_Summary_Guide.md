# Week 7 Video Guide - ServeHub (5-6 minutes)

## Setup Before Recording

1. Delete database: `Remove-Item ServeHub.db`
2. Run: `dotnet run --project ServeHub.csproj`
3. Open: http://localhost:5000

## Mock Data - Demo Accounts

**All accounts use password:** `Demo123!`

- `demo@servehub.com` - Demo User
- `volunteer@servehub.com` - Volunteer User
- `organizer@servehub.com` - Event Organizer

**Use for video:** `demo@servehub.com` / `Demo123!`

## Member 1: Browse & Filtering (60s)

- Show home page and Opportunities
- Search "park" → show live filtering
- Filter by Phoenix location
- Filter by Environment category
- Filter by date range
- Clear filters

## Member 2: Authentication (50s)

- Login with demo account
- Show navigation changes (My Registrations, Dashboard)
- Show Profile page
- Logout

## Member 3: Registration (60s)

- Login again
- Click "Community Park Cleanup"
- Register for opportunity
- Go to My Registrations → show it appears
- Cancel registration → show it's removed

## Member 4: Create & Edit (80s)

- Dashboard → Create Opportunity
- Fill: "Beach Cleanup Day", "Help clean beaches", Scottsdale, future dates, 15 volunteers
- Submit → verify in dashboard
- Edit → change title to "Beach & Park Cleanup Day"
- Save → verify update

## Member 5: Delete & Wrap (50s)

- Delete the created opportunity
- Confirm deletion → verify removed
- Show responsive design (resize browser)
- Closing: "Full CRUD, auth, filters, registrations, Azure-ready"

## Links for Submission

- **Repo**: https://github.com/kendychae/CSE325-Team4-GroupProject
- **Project Board**: https://github.com/users/kendychae/projects/2
- **Deployed Site**: [Azure URL]
- **Video**: [YouTube URL]
