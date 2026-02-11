using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServeHub.Models;

namespace ServeHub.Data;

/// <summary>
/// Seeds the database with mock data for demonstration purposes
/// </summary>
public static class DatabaseSeeder
{
    public static async Task SeedDataAsync(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        // Check if data already exists
        if (await context.ServiceOpportunities.AnyAsync())
        {
            Console.WriteLine("Database already contains data. Skipping seed.");
            return;
        }

        Console.WriteLine("Seeding database with mock data...");

        // Create demo users
        var demoUser1 = await CreateDemoUserAsync(userManager, "demo@servehub.com", "Demo User");
        var demoUser2 = await CreateDemoUserAsync(userManager, "volunteer@servehub.com", "Volunteer User");
        var demoUser3 = await CreateDemoUserAsync(userManager, "organizer@servehub.com", "Event Organizer");

        // Create service opportunities with diverse data
        var opportunities = new List<ServiceOpportunity>
        {
            new ServiceOpportunity
            {
                Title = "Community Park Cleanup",
                Description = "Join us for a morning of beautifying our local park! We'll be picking up litter, planting flowers, and maintaining trails. All ages welcome, and we'll provide gloves, trash bags, and refreshments. This is a great way to give back to our community and enjoy the outdoors.",
                Location = "Phoenix Community Park, Phoenix, AZ",
                Category = "Environment",
                StartDate = DateTime.Now.AddDays(5),
                EndDate = DateTime.Now.AddDays(5).AddHours(4),
                MaxVolunteers = 25,
                CurrentVolunteers = 8,
                ImageUrl = "https://images.unsplash.com/photo-1542601906990-b4d3fb778b09?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser1.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-10)
            },
            new ServiceOpportunity
            {
                Title = "Food Bank Sorting and Distribution",
                Description = "Help us sort and distribute food to families in need. We need volunteers to organize donations, pack boxes, and assist with distribution. No experience necessary – we'll train you on site. Your help makes a direct impact on fighting hunger in our community.",
                Location = "Tempe Community Food Bank, Tempe, AZ",
                Category = "Hunger Relief",
                StartDate = DateTime.Now.AddDays(10),
                EndDate = DateTime.Now.AddDays(10).AddHours(5),
                MaxVolunteers = 30,
                CurrentVolunteers = 15,
                ImageUrl = "https://images.unsplash.com/photo-1593113598332-cd288d649433?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser2.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-8)
            },
            new ServiceOpportunity
            {
                Title = "Senior Center Tech Help Day",
                Description = "Teach seniors how to use smartphones, tablets, and computers! We're looking for patient volunteers to help older adults navigate technology, set up email, video chat with family, and stay connected. This is an incredibly rewarding experience that bridges the digital divide.",
                Location = "Mesa Senior Center, Mesa, AZ",
                Category = "Education",
                StartDate = DateTime.Now.AddDays(15),
                EndDate = DateTime.Now.AddDays(15).AddHours(3),
                MaxVolunteers = 15,
                CurrentVolunteers = 6,
                ImageUrl = "https://images.unsplash.com/photo-1516321497487-e288fb19713f?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser3.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-6)
            },
            new ServiceOpportunity
            {
                Title = "Animal Shelter Dog Walking",
                Description = "Help provide exercise and socialization for shelter dogs! We need volunteers to walk dogs, play with them in our yards, and give them attention. It's a fun way to help animals waiting for their forever homes. Must be comfortable with dogs of all sizes.",
                Location = "Phoenix Animal Shelter, Phoenix, AZ",
                Category = "Animals",
                StartDate = DateTime.Now.AddDays(7),
                EndDate = DateTime.Now.AddDays(7).AddHours(3),
                MaxVolunteers = 12,
                CurrentVolunteers = 9,
                ImageUrl = "https://images.unsplash.com/photo-1548199973-03cce0bbc87b?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser1.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-5)
            },
            new ServiceOpportunity
            {
                Title = "Youth Reading Program Tutors",
                Description = "Become a reading buddy for elementary school students! We pair volunteers with children who need extra help with reading skills. Sessions are one-on-one or small groups, and you'll make a lasting impact on a child's literacy and confidence. Background check required.",
                Location = "Scottsdale Elementary School, Scottsdale, AZ",
                Category = "Education",
                StartDate = DateTime.Now.AddDays(12),
                EndDate = DateTime.Now.AddDays(12).AddHours(2),
                MaxVolunteers = 20,
                CurrentVolunteers = 12,
                ImageUrl = "https://images.unsplash.com/photo-1503676260728-1c00da094a0b?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser2.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-7)
            },
            new ServiceOpportunity
            {
                Title = "Habitat for Humanity Build Day",
                Description = "Join us for a Habitat for Humanity construction day! Help build homes for families in need. No construction experience required – we have tasks for all skill levels. Bring work gloves, wear closed-toe shoes, and prepare to make a tangible difference in someone's life.",
                Location = "Gilbert Construction Site, Gilbert, AZ",
                Category = "Community Development",
                StartDate = DateTime.Now.AddDays(20),
                EndDate = DateTime.Now.AddDays(20).AddHours(6),
                MaxVolunteers = 40,
                CurrentVolunteers = 18,
                ImageUrl = "https://images.unsplash.com/photo-1504307651254-35680f356dfd?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser3.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-9)
            },
            new ServiceOpportunity
            {
                Title = "Hospital Patient Companion Program",
                Description = "Bring comfort and companionship to hospital patients who don't have regular visitors. You'll spend time chatting, reading, playing games, or just providing a friendly presence. This is a deeply meaningful way to ease loneliness and brighten someone's difficult time.",
                Location = "Phoenix General Hospital, Phoenix, AZ",
                Category = "Healthcare",
                StartDate = DateTime.Now.AddDays(8),
                EndDate = DateTime.Now.AddDays(8).AddHours(4),
                MaxVolunteers = 10,
                CurrentVolunteers = 7,
                ImageUrl = "https://images.unsplash.com/photo-1519494026892-80bbd2d6fd0d?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser1.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-4)
            },
            new ServiceOpportunity
            {
                Title = "River Cleanup Initiative",
                Description = "Help protect our waterways! Join the Salt River cleanup crew to remove trash and debris from the riverbanks. We'll provide all equipment including waders, gloves, and trash bags. This effort directly improves water quality and wildlife habitats. Light refreshments provided.",
                Location = "Salt River Recreation Area, Mesa, AZ",
                Category = "Environment",
                StartDate = DateTime.Now.AddDays(18),
                EndDate = DateTime.Now.AddDays(18).AddHours(5),
                MaxVolunteers = 35,
                CurrentVolunteers = 14,
                ImageUrl = "https://images.unsplash.com/photo-1618477461853-cf6ed80faba5?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser2.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-11)
            },
            new ServiceOpportunity
            {
                Title = "Homeless Shelter Meal Service",
                Description = "Serve meals to individuals experiencing homelessness at our downtown shelter. We need volunteers to help with food prep, serving, and cleanup. This is an opportunity to show compassion and provide nourishment to our community's most vulnerable members.",
                Location = "Downtown Phoenix Shelter, Phoenix, AZ",
                Category = "Hunger Relief",
                StartDate = DateTime.Now.AddDays(3),
                EndDate = DateTime.Now.AddDays(3).AddHours(4),
                MaxVolunteers = 15,
                CurrentVolunteers = 11,
                ImageUrl = "https://images.unsplash.com/photo-1488521787991-ed7bbaae773c?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser3.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-3)
            },
            new ServiceOpportunity
            {
                Title = "Youth Mentorship Program Orientation",
                Description = "Join our youth mentorship program! Attend this orientation to learn how you can become a mentor to at-risk youth in our community. We'll cover program guidelines, expectations, and match you with a mentee. Commit to making a long-term difference in a young person's life.",
                Location = "Chandler Community Center, Chandler, AZ",
                Category = "Youth Development",
                StartDate = DateTime.Now.AddDays(14),
                EndDate = DateTime.Now.AddDays(14).AddHours(3),
                MaxVolunteers = 25,
                CurrentVolunteers = 16,
                ImageUrl = "https://images.unsplash.com/photo-1491438590914-bc09fcaaf77a?w=600&h=400&fit=crop",
                IsActive = true,
                CreatedByUserId = demoUser1.Id,
                CreatedAt = DateTime.UtcNow.AddDays(-12)
            }
        };

        context.ServiceOpportunities.AddRange(opportunities);
        await context.SaveChangesAsync();

        Console.WriteLine($"Successfully seeded {opportunities.Count} service opportunities!");
    }

    private static async Task<ApplicationUser> CreateDemoUserAsync(UserManager<ApplicationUser> userManager, string email, string displayName)
    {
        var user = await userManager.FindByEmailAsync(email);
        if (user == null)
        {
            user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(user, "Demo123!");
            if (result.Succeeded)
            {
                Console.WriteLine($"Created demo user: {email}");
            }
            else
            {
                Console.WriteLine($"Failed to create demo user {email}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
            }
        }

        return user;
    }
}
