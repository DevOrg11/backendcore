# BackendCore: Clean Architecture Implementation with .NET Core
## Summary
This projects main purpose is to follow the concepts of Clean/Onion/Hexagonal Architecture.
This is a .net 6 solution consisting of 4 layers:
1. Presentation layer - Is a .net API project used as an interface to interact with the user (Clean.Api)
2. Application layer - Is a class library where the service layer exists (Clean.Application) \
   NOTE: Unit testing will be conducted for this layer (Service methods) in a separate project (Clean.Application.Tests)
3. Domain layer - Is a class library that only contains entities and has no dependancies (Clean.Domain)
4. Infrastrcture layer - Is a class library where the DBcotext and the repository implementations exists (Clean.Infrastructure) \  
NOTE: Unit testing will also be conducted here. This project is using entity framework.
## Initial Setup
1. Clone the repository to your local drive
2. Build the entire solution
3. If you are on vs code, go to terminal and navigate to Clean.Api folder (cd src/Clean.Api)
4. In vs code under terminal type in => dotnet tool install --global dotnet-ef first
5. Type in the migration code => dotnet ef database update
6. This will create the database on your local drive.
7. Run the program ( dotnet run )
## Currently only two functions are implemented
1. Get All items function => https://localhost:<port number>/items
2. Post item function => https://localhost:<port number>/item
                        Under body place the below example format
```json
                        {
                        "name": "Blender",
                        "category": 1,
                        "amount": 1,
                        "description": "for parts",
                        "prise": 4200,
                        "availability": 1
                        }
 ```                       
NOTE: You can use swagger to perform the above two => https://localhost:<port number>/swagger
***
If you would like to contribute please follow the branching practice mentioned [here](https://github.com/DevOrg11/backendcore/wiki)
