# Week 7 Video Summary Guide

## Video Requirements Checklist

### Format & Duration
- [ ] **Length**: 5-7 minutes total
- [ ] **Platform**: Uploaded to YouTube
- [ ] **Participation**: Every team member presents a portion
- [ ] **Camera**: Each member uses their own camera when presenting

## Video Structure & Content Map

### 1. Introduction (30-45 seconds)
**Presenter**: [Team Member Name]

**Cover**:
- Project name: ServeHub - Volunteer Management Platform
- Team identification: CSE 325 Team 4, Winter 2026
- Brief overview: "A Blazor Server web application connecting volunteers with community service opportunities"

### 2. Application Overview & Navigation (45-60 seconds)
**Presenter**: [Team Member Name]

**Demonstrate**:
- Home page and main navigation
- Responsive design (show mobile view if possible)
- Overall branding and user interface consistency
- Navigation structure and menu items

**Rubric Points**:
- ✓ Consistent branding
- ✓ Clear navigation structure
- ✓ Responsive design

### 3. User Authentication System (60-75 seconds)
**Presenter**: [Team Member Name]

**Demonstrate**:
- Registration process
  - Show the registration form
  - Point out password requirements/validation
  - Complete a sample registration
- Login functionality
  - Show login form
  - Demonstrate successful login
  - Show how navigation changes for authenticated users
- Profile page (if implemented)

**Rubric Points**:
- ✓ User authentication implemented
- ✓ ASP.NET Core Identity integration
- ✓ Secure registration and login

### 4. CRUD Operations - Create & Read (75-90 seconds)
**Presenter**: [Team Member Name]

**Demonstrate**:
- Navigate to Dashboard (logged-in view)
- **Create**: Click "Create Opportunity" button
  - Show the create form
  - Fill out fields (Title, Description, Location, Dates, Max Volunteers)
  - Submit and show success
- **Read**: Show the newly created opportunity on the dashboard
  - Point out the list/table view
  - Show opportunity details

**Rubric Points**:
- ✓ Create functionality working
- ✓ Read/Display functionality working
- ✓ Form validation
- ✓ Data persistence

### 5. CRUD Operations - Update & Delete (60-75 seconds)
**Presenter**: [Team Member Name]

**Demonstrate**:
- **Update**: Click "Edit" on an opportunity
  - Show the edit form with pre-populated data
  - Modify at least one field
  - Save and show the updated data
- **Delete**: Click "Delete" on an opportunity
  - Show confirmation (if implemented)
  - Delete and verify it's removed from the list

**Rubric Points**:
- ✓ Update functionality working
- ✓ Delete functionality working
- ✓ Ownership verification (users can only edit/delete their own opportunities)

### 6. Enhancement Features (60-75 seconds)
**Presenter**: [Team Member Name]

**Demonstrate**:
- Browse Opportunities page (public view)
- **Search functionality**:
  - Search by title/description
  - Show filtered results
- **Category filtering**:
  - Select a category from dropdown
  - Show filtered results
- **Location filtering**:
  - Enter a location
  - Show filtered results
- **Date range filtering**:
  - Select start date range (from/to)
  - Show opportunities filtered by date
- **Clear filters** button

**Rubric Points**:
- ✓ Search/filter functionality
- ✓ Date range filtering
- ✓ Multiple filter types working together
- ✓ User-friendly filter interface

### 7. Database & Cloud Integration (30-45 seconds)
**Presenter**: [Team Member Name]

**Show/Explain**:
- Briefly mention Azure SQL Database integration
  - "Our application uses Azure SQL Database for data persistence"
  - Show that data persists across sessions (refresh page, data still there)
- Entity Framework Core integration
  - Can briefly show code if desired, or just mention it
- Deployment readiness
  - "Application is configured for Azure App Service deployment"

**Rubric Points**:
- ✓ Database integration
- ✓ Cloud deployment configuration
- ✓ Data persistence

### 8. Additional Features & Quality (30-45 seconds)
**Presenter**: [Team Member Name]

**Demonstrate/Mention**:
- Accessibility features
  - Semantic HTML
  - Keyboard navigation
  - ARIA labels (can briefly mention)
- Performance
  - Fast page loads
  - Server-side rendering benefits
- Code quality
  - Organized project structure
  - Separation of concerns (Services, Models, Data)

**Rubric Points**:
- ✓ WCAG 2.1 compliance efforts
- ✓ Performance optimization
- ✓ Professional code organization

### 9. Conclusion (15-30 seconds)
**Presenter**: [Team Member Name]

**Wrap up**:
- Recap: "We've demonstrated a complete Blazor Server application with:"
  - User authentication
  - Full CRUD operations
  - Multiple search and filter features
  - Cloud database integration
  - Professional design and accessibility
- Thank the instructor and class

## Recording Tips

### Before Recording
- [ ] Test all features to ensure they work
- [ ] Prepare sample data for demonstration
- [ ] Clear browser cache/cookies for clean demo
- [ ] Close unnecessary tabs/applications
- [ ] Test microphone and camera quality
- [ ] Practice transitions between presenters

### During Recording
- [ ] Speak clearly and at a moderate pace
- [ ] Keep browser in full-screen mode
- [ ] Zoom in on important elements when needed
- [ ] Pause briefly between presenters for clean editing
- [ ] Show your camera when you're presenting

### After Recording
- [ ] Review the video for quality
- [ ] Check audio levels are consistent
- [ ] Verify all requirements are covered
- [ ] Edit if necessary (trimming, transitions)
- [ ] Upload to YouTube (unlisted or public as required)

## Checklist Against Rubric

### Required Submissions
- [ ] Link to GitHub repository
- [ ] Link to GitHub Project board
- [ ] Link to deployed application (Azure App Service)
- [ ] Link to YouTube video

### Project Specifications Demonstrated
- [ ] Blazor web application ✓
- [ ] User authentication ✓
- [ ] CRUD functionality ✓
- [ ] Database integration ✓
- [ ] Quality testing ✓
- [ ] GitHub repository management ✓
- [ ] Code comments and documentation ✓
- [ ] Cloud deployment ✓

### Design Standards Shown
- [ ] Performance optimization ✓
- [ ] Valid markup and styling ✓
- [ ] Accessibility (WCAG 2.1 Level AA) ✓
- [ ] Usability and responsive design ✓
- [ ] Consistent branding ✓
- [ ] Clear navigation ✓

## Team Member Assignments

| Team Member | Section | Estimated Time |
|-------------|---------|----------------|
| [Name] | Introduction | 30-45 sec |
| [Name] | App Overview & Navigation | 45-60 sec |
| [Name] | Authentication | 60-75 sec |
| [Name] | CRUD - Create & Read | 75-90 sec |
| [Name] | CRUD - Update & Delete | 60-75 sec |
| [Name] | Enhancement Features | 60-75 sec |
| [Name] | Database & Cloud | 30-45 sec |
| [Name] | Additional Features | 30-45 sec |
| [Name] | Conclusion | 15-30 sec |

**Total**: Approximately 6-7 minutes

---

## Notes

- Keep individual sections concise and focused
- Transitions should be smooth
- Each presenter should introduce themselves briefly
- Practice timing to stay within 5-7 minute limit
- Focus on showing working features, not explaining code details
- Demonstrate real functionality, not mock-ups
