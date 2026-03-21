# IronVault Data Seed (GMS)

Backend slice of the **IronVault** / **GMS** (gym management) stack: an ASP.NET Core web host with **Entity Framework Core**, **SQL Server**, and **reference data** defined in code so you can create a predictable local or shared database for development and demos.

## What this repository contains

| Area | Description |
|------|-------------|
| **Domain model** | Entities under `GMS/Entities/Models` (users, memberships, trainers, nutritionists, seminars, supplements, orders, FAQs, roles, attendance, etc.). |
| **Seed data** | `HasData(...)` in `GMS/Configuration/*.cs` — cities, genders, sample users (with profile images), trainers, products, reviews, and related rows. |
| **Schema** | EF Core migration `GMS/Migrations/20240929235358_init` creates tables and applies the same seed payload. |
| **Static assets** | `GMS/wwwroot` holds JPGs used when seeding binary image columns for users, trainers, and supplements. |
| **API host** | `GMS/Program.cs` registers `ApplicationDbContext`, controllers pipeline, CORS (open), static files, and Swagger middleware. |

The solution file is **`GMS.sln`**; the web project is **`GMS/GMS.csproj`**.

## Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) (project targets `net7.0`)
- [SQL Server](https://www.microsoft.com/sql-server) (LocalDB, Express, or full instance) reachable from your machine

> **Note:** .NET 7 is out of support. For production, plan a move to a current LTS (e.g. .NET 8).

## Configuration

1. Open `GMS/appsettings.json` and set **`ConnectionStrings:db1`** to your SQL Server instance and database name (default in repo is oriented toward a local database named `GMS_db`).
2. **Do not commit real secrets.** Prefer [User Secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets) or environment variables for connection strings, SMTP, and Azure AD placeholders. Rotate any credentials that were ever checked into source control.

The app builds a `ConfigurationBuilder` that loads `appsettings.json` for the database connection used by `ApplicationDbContext`.

## Apply migrations and seed the database

From the repository root (or from `GMS`):

```powershell
cd GMS
dotnet ef database update
```

This creates/updates the database and applies the migration, including bundled seed data.

If the `dotnet ef` tool is not available, install it once (global example):

```powershell
dotnet tool install --global dotnet-ef
dotnet ef database update --project GMS.csproj
```

Use a matching `dotnet-ef` version for your EF Core packages (this project uses EF Core 6.x).

## Run the web project

```powershell
cd GMS
dotnet run
```

Default launch profile URLs (see `GMS/Properties/launchSettings.json`):

- HTTPS: `https://localhost:7174`
- HTTP: `http://localhost:5174`

The profile opens **`/swagger`** in the browser. If Swagger does not load, ensure `AddSwaggerGen()` (and related Swashbuckle registration) is wired up in `Program.cs` to match the existing `UseSwagger` / `UseSwaggerUI` calls.

## How seeding works

- **Fluent configurations** in `GMS/Configuration` implement `IEntityTypeConfiguration<T>` and call `builder.HasData(...)`.
- **Images**: helpers such as `ConvertImageToByteArray` read files under `wwwroot` at migration/design time; keep those files present if you regenerate migrations or rely on the existing snapshot.

To change seed content, edit the relevant configuration class, then add a new EF migration (or adjust carefully if you are only touching seed data and know the impact on existing databases).

## Project layout (short)

```
GMS.sln
GMS/
  Program.cs                 # App startup, DbContext, middleware
  appsettings.json           # Connection string and app settings
  Data/ApplicationDbContext.cs
  Entities/Models/           # POCO entities
  Configuration/             # EF mappings + HasData seeds
  Migrations/                # Initial schema + data
  wwwroot/                   # Images used by seed configurations
```

## License / attribution

Add your license and team attribution here if this repo is published or shared.
