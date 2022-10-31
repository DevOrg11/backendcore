# BackendCore: Clean Architecture Implementation with .NET Core


## Initial Setup

1.Clone the repository to your local drive

2.Build the entire solution

3.If you are on vs code, go to terminal and navigate to Clean.Api folder (cd src/Clean.Api)

4.Type in the migration code => dotnet ef database update

5.This will create the database on your local drive.

6.Run the program ( dotnet run )

## Currently only two functions are implemented:

2.Get All items function => https://localhost:<port number>/items

3.Post item function => https://localhost:<port number>/item
                        Under body place the below example format

                        {
                        "name": "Blender",
                        "category": 1,
                        "amount": 1,
                        "description": "for parts",
                        "prise": 4200,
                        "availability": 1
                        }
                        

4.You can use swagger to perform the above two => https://localhost:<port number>/swagger

***

If you would like to contribute please follow the branching practice mentioned [here](https://github.com/DevOrg11/backendcore/wiki)
