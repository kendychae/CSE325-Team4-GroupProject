#!/bin/bash
# Install EF Core tools
dotnet tool install --global dotnet-ef --version 8.0.0

# Run migrations
cd /home/site/wwwroot
dotnet ef database update --project . --startup-project . --verbose

# Start the application
exec dotnet ServeHub.dll
