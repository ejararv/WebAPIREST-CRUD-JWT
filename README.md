# WebAPIREST-CRUD-JWT
##StudentClub Web API

> **Angular v9** Single Page Application with an ASP.NET Core WebAPI that uses token authentication. 
> The OAuth 2.0 [Resource Owner Password Credentials grant](https://tools.ietf.org/html/rfc6749#section-4.3) (ROPC) is implemented using IdentityServer4 
> and ASP.NET Core Identity as membership system with a SQLite database.


[Live example](https://angularspawebapi.azurewebsites.net) and its [explanation](https://github.com/robisim74/AngularSPAWebAPI/blob/master/EXPLANATION.md).


> For more complex scenarios, where web services are required by more than one application or third-party applications, 
you should use an OpenID Connect implicit flow.

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
	- **PersonController.cs** _Auth _
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
	- At least [.NET Core 2.1](https://www.microsoft.com/net/download/core)
	- [Node.js and npm](https://nodejs.org)
    - At least [Angular CLI 7.0.0](https://github.com/angular/angular-cli)

#### Command line & .NET Core CLI
- In _ClientApp_ folder run: `npm install`
- `dotnet build`

#### Visual Studio 2017
- In _ClientApp_ folder run: `npm install`
- Build the solution

## Running
The app will be served on `https://localhost:5001`

### Command line & .NET Core CLI
#### Development
- `dotnet watch run`

#### Staging
- In _ClientApp_ folder run: `npm run build:staging`
- `dotnet run --launch-profile Staging`

### Visual Studio 2017
#### Development
- Select _AngularSPAWebAPI_ profile
- Start debugging

#### Staging
- In _ClientApp_ folder run: `npm run build:staging`
- Select _Staging_ profile
- Start debugging

## Deployment
- In _ClientApp_ folder run: `npm run build:prod`
- Publish

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
