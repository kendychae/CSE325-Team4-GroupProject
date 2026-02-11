# Week 7 Video Summary Guide - ServeHub

## 🎥 Requirements

- **Length**: 5-7 minutes
- **Platform**: YouTube
- **Each member**: Uses own camera and presents a section

## 🚀 BEFORE Recording

1. **Delete database**: `Remove-Item ServeHub.db`
2. **Run app**: `dotnet run --project ServeHub.csproj`
3. **Verify seeding**: Check console shows "Successfully seeded 10 service opportunities!"
4. **Open browser**: http://localhost:5000

## 🎬 Video Sections (5-6 minutes total)

### Member 1: Intro & Browse Features (60 sec)

**Say**: "ServeHub - Volunteer Management Platform by CSE 325 Team 4"

**Show**:

- Home page - quick overview
- Navigate to Opportunities page
- Point out 10 seeded opportunities across different categories
- Type "park" in search box - show filtering
- Type "Phoenix" in location - show filtering
- Select "Environment" category - show filtering
- Select date range - show filtering
- Click "Clear Filters" - show reset
- Point out results count updating

**Covers**: Search, filtering, UI

---

### Member 2: Authentication (50 sec)

**Login**: Use `demo@servehub.com` / `Demo123!`

**Show**:

- Login page and form
- Submit login
- Notice navigation changes (My Registrations, Dashboard appear)
- Click Profile - show user info
- Logout
- Optionally show registration form briefly

**Covers**: User authentication, Identity integration

---

### Member 3: Opportunity Details & Registration (60 sec)

**Login again**: `demo@servehub.com` / `Demo123!`

**Show**:

- Click on "Community Park Cleanup" opportunity
- Show details page (description, location, dates, volunteers)
- Click "Register" button
- Show success message
- Navigate to "My Registrations"
- Show registered opportunity appears in "Upcoming Events"
- Click "Cancel Registration"
- Show it's removed

**Covers**: Registration system, My Registrations page

---

### Member 4: CRUD - Create & Edit (80 sec)

**Stay logged in**

**Show**:

- Navigate to Dashboard
- Click "Create Opportunity"
- **Fill form**:
  - Title: "Beach Cleanup Day"
  - Description: "Help clean our local beaches"
  - Location: "Scottsdale, AZ"
  - Start Date: (future date)
  - End Date: (after start)
  - Max Volunteers: 15
- Submit - show it appears in dashboard
- Click "Edit" on the new opportunity
- Change title to "Beach & Park Cleanup Day"
- Save - show updated

**Covers**: Create (C), Read (R), Update (U)

---

### Member 5: CRUD - Delete & Wrap-up (50 sec)

**Show**:

- From dashboard, click "Delete" on the opportunity you created
- Confirm deletion
- Show it's removed from dashboard
- Quickly show responsive design (resize browser or use dev tools)
- Navigate through pages showing mobile view

**Say**: "We've demonstrated authentication, full CRUD operations, search/filters, registrations, and cloud-ready database integration. Thank you!"

**Covers**: Delete (D), Responsive design

---

## 📋 Pre-Recording Checklist

- [ ] Fresh database seeded (10 opportunities)
- [ ] Demo account ready: `demo@servehub.com` / `Demo123!`
- [ ] Browser cache cleared
- [ ] All team members tested their section
- [ ] Camera/mic working for each member
- [ ] Screen recording software ready
- [ ] Close unnecessary apps/tabs

## ✅ W7 Requirements Coverage

- ✅ Authentication (login, register, logout, profile)
- ✅ CRUD complete (create, read, update, delete)
- ✅ Search & filtering (text, location, category, date)
- ✅ Database integration (seeded data persists)
- ✅ My Registrations page
- ✅ Responsive design
- ✅ Azure deployment ready
- ✅ Each member participates with camera

## 📤 Submission Links Needed

1. GitHub repository: `https://github.com/kendychae/CSE325-Team4-GroupProject`
2. Trello board: [Your Trello link]
3. Deployed site: [Your Azure App Service URL]
4. YouTube video: [Your video link after upload]
