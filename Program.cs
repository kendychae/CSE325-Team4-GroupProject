using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServeHub.Components;
using ServeHub.Data;
using ServeHub.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();

// Supports both SQL Server and SQLite
// Add Database Context - Explicitly handle development vs production
var isDevelopment = builder.Environment.IsDevelopment();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Connection string not configured.");
}

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    if (isDevelopment && connectionString.Contains(".db"))
    {
        // Development with SQLite
        options.UseSqlite(connectionString);
        Console.WriteLine("Using SQLite for Development");
    }
    else
    {
        // Production or LocalDB - Use SQL Server
        options.UseSqlServer(connectionString, sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
        });
        Console.WriteLine($"Using SQL Server for {(isDevelopment ? "Development (LocalDB)" : "Production (Azure)")}");
    }
});

// Add Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    // Password settings
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;

    // User settings
    options.User.RequireUniqueEmail = true;

    // Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

// Add Authentication State Provider for Blazor
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

// Configure authentication cookie
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/Account/Logout";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromDays(7);
    options.SlidingExpiration = true;
});

// Add application services
builder.Services.AddScoped<IServiceOpportunityService, ServiceOpportunityService>();
builder.Services.AddScoped<IRegistrationService, RegistrationService>();

var app = builder.Build();

// Apply migrations automatically at startup
// using (var scope = app.Services.CreateScope())
// {
//     var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
//     dbContext.Database.Migrate();
// }

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    
    try
    {
        dbContext.Database.Migrate();
    }
    catch (Exception ex)
    {
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Database migration failed at startup.");
        // Don't rethrow — let the app start so you can diagnose via logs
    }

    // Seed demo data for video demonstration
    try
    {
        await DatabaseSeeder.SeedDataAsync(dbContext, userManager);
    }
    catch (Exception ex)
    {
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Database seeding failed at startup.");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    
}

app.UseStatusCodePagesWithReExecute("/not-found");
// app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapPost("/account/login-handler", async (HttpRequest httpRequest, SignInManager<ApplicationUser> signInManager) =>
{
    var form = await httpRequest.ReadFormAsync();
    var email = form["Email"].ToString();
    var password = form["Password"].ToString();
    var rememberMeRaw = form["RememberMe"].ToString();
    var rememberMe = string.Equals(rememberMeRaw, "true", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(rememberMeRaw, "on", StringComparison.OrdinalIgnoreCase);

    if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
    {
        return Results.Redirect("/Account/Login?error=missing");
    }

    var result = await signInManager.PasswordSignInAsync(email, password, rememberMe, lockoutOnFailure: true);

    if (result.Succeeded)
    {
        return Results.Redirect("/dashboard");
    }

    if (result.IsLockedOut)
    {
        return Results.Redirect("/Account/Login?error=locked");
    }

    return Results.Redirect("/Account/Login?error=invalid");
}).AllowAnonymous();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

