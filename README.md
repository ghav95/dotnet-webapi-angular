# Objectives 
Developed with a focus on creating a dynamic and responsive ✨API ✨complemented by a Single Page Application (SPA), this project showcases its evolving design and progressive realization of project goals. Emphasizing the simplicity and clarity inherent in Clean Code/Architecture principles, the implementation is geared towards delivering a streamlined and efficient solution.
The technology stack employed includes cutting-edge tools such as .NET Core 5, Angular 12, and Entity Framework Core, serving as the project's robust foundation. The use of these technologies ensures a modern and scalable architecture, laying the groundwork for a seamless user experience and efficient data management.

# Author
_Gabriel Henrique Alves Vieira_ [Linkedin](https://www.linkedin.com/in/ghav95/) / [Github](https://github.com/ghav95)

## Requirements
- [.NET 5.0.102](https://dotnet.microsoft.com/pt-br/download/dotnet/5.0)
- [VS Code](https://code.visualstudio.com/download)
- [NodeJS](https://nodejs.org/en)
- [DB Browser for SQLite](https://sqlitebrowser.org/dl/)

### Install Angular 12
 ```sh
npm install -g @angular/cli@12
```
### Create folder
 ```sh
 mkdir ProEventos/Server/src/ProEventos.API
 ```
#### Create new webapi template
 ```sh
 cd ProEventos.API 
 dotnet new webapi -n ProEventos.API 
 ```
 >Help: dotnet new webapi -h
 
#### Start API
 ```sh
cd ProEventos.API
dotnet run
```

#### Start Watch
 ```sh
 cd ProEventos.API 
 dotnet watcher run
 ```
#### Logging CLI Information
appsettings.json -> Logging -> LogLevel -> "Information"

#### Generated Template 
| Controller | URL |
| ------ | ------ |
| WeatherForecast | http://localhost:5000/weatherforecast |
| Swagger | http://localhost:5000/swagger/index.html |

## Install Entity Framework (5.0.2) 
 ```sh
 dotnet tool install --global dotnet-ef --version 5.0.2  
 ``` 
 > Unistall: dotnet tool uninstall dotnet-ef -g

### Verify EF installation
 ```sh
dotnet-ef
 ```
## Install Entity Framework references using NuGet Gallery
 On VsCode: (ctrl + shift + P) -> Open Nugget Gallery

| Package | File | Version|
| ------ | ------ | ------ |
| Microsoft.EntityFrameworkCore | .csproj | 5.0.2
| Microsoft.EntityFrameworkCore.Tools | .csproj | 5.0.2
| Microsoft.EntityFrameworkCore.Design | .csproj | 5.0.2
| Microsoft.EntityFrameworkCore.Sqlite | .csproj | 5.0.2

### Model
Create Model folder
 ```sh
cd ProEventos.API 
mkdir Models
``` 
Create Model Class
```sh
cd ProEventos.API/Models 
New-item Evento.cs
``` 

Evento.cs
```sh
namespace ProEventos.API.Models
{
    public class Evento
    {
        [Key]
        public int IdEvento { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }
    }
}
```

### Data Context
Create Data folder
 ```sh
 cd ProEventos.API 
 mkdir Data
 ```
Create class DataContext.cs
```sh
 cd ProEventos.API/Data
 New-item DataContext.cs
 ```
 Implements Interface DBContext and pass DataContext as a DbContextOptions to your base constructor 
 ```sh
 namespace ProEventos.API.Data
{
    public class DataContext : DbContext    
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set; }
    }
}
```

Inject DataContext Dependency as a service on Startup.cs
```sh
namespace ProEventos.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(
                context => context.UseSqlite(Configuration.GetConnectionString("Default"))
            );
        ...
}
```
 Add ConnectionStrings on appsettings.json
```sh
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```
### Migrations
 ```sh
 mkdir Data/Migrations
 cd ProEventos.API/Data/Migrations
dotnet ef migrations add Initial -o Data/Migrations
 ```

### Create/Update DataBase using Migrations
 ```sh
dotnet ef database update
 ```

## License
MIT

**Free Software!**