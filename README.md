The objective is to build a responsive API with some SPA to show the design and the project goals building graduativaly, valuing simplicity of the Clean Code/Architecture. 
Technologies used: .NET Core 5, Angular 12, Entity Framework Core as ORM.

REQUIREMENTS
Install NodeJS: https://nodejs.org/en NodeJS come with npm (Node Package Manager)
Install .NET 5.0.102: https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer
Install Angular 12: npm install -g @angular/cli@12

STEP BY STEP 
Create new webapi template: dotnet new webapi -n ProEventos.API 
Helper: dotnet new webapi -h

START API
cd ProEventos.API
dotnet run

START WATCH
dotnet watcher run

LOGGING (Information, Warning)
appsettings -> Logging -> LogLevel -> Information/Warning

CONTROLLER URI: http://localhost:5000/weatherforecast
SWAGGER URI:  http://localhost:5000/swagger/index.html

ENTITY FRAMEWORK (5.0.2)
Install: dotnet tool install --global dotnet-ef --version 5.0.2  
Unistall: dotnet tool uninstall dotnet-ef -g
Show ef installed: dotnet-ef

PACKAGE REFERENCES EF IN .NET PROJECT (NuGet Gallery)
(ctrl + shift + P) Open Nugget Gallery 
Microsoft.EntityFrameworkCore           -> Install in .csproj (5.0.2)
Microsoft.EntityFrameworkCore.Tools     -> Install in .csproj (5.0.2)
Microsoft.EntityFrameworkCore.Design    -> Install in .csproj (5.0.2)
Microsoft.EntityFrameworkCore.Sqlite    -> Install in .csproj (5.0.2)

CREATING A DATA CONTEXT 
Create DataContext.cs and Implements Interface DBContext
Inject DataContext Dependency as a service on Startup.cs
Add ConnectionStrings on appsettings.json