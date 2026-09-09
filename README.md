# ILoggerSample

[![Build status](https://ci.appveyor.com/api/projects/status/1me5i8t9ipxmsb2r?svg=true)](https://ci.appveyor.com/project/Mahadenamuththa/iloggersample)
[![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/download/dotnet/6.0)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Web%20API-512BD4?logo=dotnet)](https://learn.microsoft.com/aspnet/core/)
[![Language](https://img.shields.io/badge/language-C%23-239120?logo=csharp)](https://learn.microsoft.com/dotnet/csharp/)
[![Last commit](https://img.shields.io/github/last-commit/Mahadenamuththa/ILoggerSample)](https://github.com/Mahadenamuththa/ILoggerSample/commits/main)

ILoggerSample is a .NET 6 sample solution that demonstrates a layered ASP.NET Core application structure. The API project hosts the web application, while the application project contains service-registration logic such as AutoMapper setup.

## Projects

- `src/ILS.Api` - ASP.NET Core Web API entry point.
- `src/ILS.Application` - Application-layer service configuration.

## Requirements

- .NET 6 SDK

## Getting Started

Restore dependencies:

```powershell
dotnet restore ILoggerSample.sln
```

Build the solution:

```powershell
dotnet build ILoggerSample.sln --configuration Release --no-restore
```

Run the API:

```powershell
dotnet run --project src/ILS.Api/ILS.Api.csproj
```

When running in the Development environment, Swagger UI is enabled for exploring the API.

## Continuous Integration

AppVeyor is configured in `appveyor.yml` to restore packages and build the solution in Release configuration.
