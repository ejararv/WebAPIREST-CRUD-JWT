# WebAPIREST-CRUD-JWT
##StudentClub Web API


> and ASP.NET Core Identity as membership system with a SQLite database.



## Features
- Angular v9 & ASP.NET Core 3.0
- Angular CLI
- Angular CLI, .NET Core CLI or Visual Studio 2019
- Angular Material
- IdentityServer4 & ASP.NET Core Identity
- Resource Owner Password Credentials grant
- Refresh token
- Role based Authorization
- Development, Staging & Production environments

## Project structure
The structure of the project is based on [Angular CLI ASP.NET Core](https://github.com/robisim74/AngularCliAspNetCore).

**WebAPI**
- **ClientApp** _Angular application_
- **Controllers**
	- **UserController.cs** _Users APIs_
	- **AccountController.cs** _Auth _
	- **UploadController.cs** _Students can upload files on the server _
	
- **Data** _Entity Framework_ migrations
- **Models**
	- **Persons.cs** _Profile data for application person_
    - **Users.cs** _Profile data for application users_
- **Properties**
	- **lanchSettings.json** _ASP.NET Core environments_
- **Services**
	- **DbInitializer.cs** _Provides method to populate the db_
- **wwwroot** _Root for Angular application deployment_
    - **Users.html** [Simple page whith CRUD methods](https://localhost:44356/users.html).
    - **tokenlog.html** [Auth test page](https://localhost:44356/tokenlog.html).
- **Config.cs** _IdentityServer4 configuration_
- **IdentityDB.sqlite** _SQLite database_
- **Startup.cs** _WebAPI configuration_

## Installing
- Requirements
	-  [.NET Core 3.0](https://www.microsoft.com/net/download/core)
	





## Running
The app will be served on `https://localhost:44356/`

### Command line & .NET Core CLI
#### Development
- `dotnet watch run`

#### Staging
- In _ClientApp_ folder run: `npm run build:staging`
- `dotnet run --launch-profile Staging`


## Changing db
To use another database, for example _SQLServer_:
- Edit in _Startup.cs_:
```C#
services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
```
- Edit `ConnectionStrings` in _appsettings.json_:
```Json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=IdentityDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

## License
MIT
