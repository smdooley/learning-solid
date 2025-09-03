#!/usr/bin/env bash
# set -e

# Create solution root
# mkdir Animals
# cd Animals

# Create solution file
dotnet new sln -n Animals

# Create projects
dotnet new classlib -n Animals.Domain     -o src/Animals.Domain
dotnet new classlib -n Animals.Application -o src/Animals.Application
dotnet new classlib -n Animals.Infrastructure -o src/Animals.Infrastructure
dotnet new webapi   -n Animals.Api        -o src/Animals.Api

# Add projects to solution
dotnet sln add src/Animals.Domain/Animals.Domain.csproj
dotnet sln add src/Animals.Application/Animals.Application.csproj
dotnet sln add src/Animals.Infrastructure/Animals.Infrastructure.csproj
dotnet sln add src/Animals.Api/Animals.Api.csproj

# Set references between layers
dotnet add src/Animals.Application/Animals.Application.csproj reference src/Animals.Domain/Animals.Domain.csproj
dotnet add src/Animals.Infrastructure/Animals.Infrastructure.csproj reference src/Animals.Application/Animals.Application.csproj
dotnet add src/Animals.Infrastructure/Animals.Infrastructure.csproj reference src/Animals.Domain/Animals.Domain.csproj
dotnet add src/Animals.Api/Animals.Api.csproj reference src/Animals.Application/Animals.Application.csproj
dotnet add src/Animals.Api/Animals.Api.csproj reference src/Animals.Infrastructure/Animals.Infrastructure.csproj
dotnet add src/Animals.Api/Animals.Api.csproj reference src/Animals.Domain/Animals.Domain.csproj

# Install EF Core packages (Infrastructure)
dotnet add src/Animals.Infrastructure package Microsoft.EntityFrameworkCore
dotnet add src/Animals.Infrastructure package Microsoft.EntityFrameworkCore.Sqlite
dotnet add src/Animals.Infrastructure package Microsoft.EntityFrameworkCore.InMemory

# Install Swagger (API)
dotnet add src/Animals.Api package Swashbuckle.AspNetCore

# Optional: install FluentValidation for Application layer
dotnet add src/Animals.Application package FluentValidation
