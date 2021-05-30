# .Net-GraphQL-HotChocolate

## Requirements for the project
* VS Code (Recommended)
* Insomnia (Recommended)/Postman (Option)
* .NET 5
* Docker / SQL Server Express

## Installation
1. Create and direct to project directory. In my case main repo is the root dir.
2. Run the code by replacing your name for the project folder. In the repo it is named as `Project`. `dotnet new web -n <NAME HERE>`.
3. To install packages direct to the Project dir which you just created. Here it is `cd Prokect`.
    * Install `HotChocolate` latest Nugget package: `dotnet add package HotChocolate.AspNetCore`
    * Adding another HotChocolate package `dotnet add package HotChocolate.Data.Entityframework` 
    * Microsoft EntityFWCore package - `dotnet add package Microsoft.EntityframeworkCore.Design`
    * Microsoft EntityFWCore for SQL Server - `dotnet add package Microsoft.EntityframeworkCore.SqlServer`
    * (Optional) Graphical Interface to view GraphQL Schema `dotnet add package GraphQL.Server.Ui.Voyager`

4. Setting up SQL Server. 
    Setup with Docker (should be installed). In the repo there is `docker-compose.yaml` already. If not : 
    ```yaml
    version: '3'
    services: 
        sqlserver:
        image: "mcr.microsoft.com/mssql/server:2017-latest"
        environment: 
            ACCEPT_EULA: "Y"
            SA_PASSWORD: "@sdf1234"
            MASSQL_PID: "Express"
        ports:
            - "1433:1433"
    ```
    Get to the directory containing the `docker-compose.yaml` file. Run `docker-compose up -d` . After this operation you will have a new image in your docker. To stop Docker run `docker-compose stop`. Optional to install [SQL Server](https://marketplace.visualstudio.com/items?itemName=ms-mssql.mssql) extension for VS Code.  
    Configuraitons of the extension:  
    * connection: `localhos,1433`
    * database : [enter]
    * Authentication Type SQL Login
    * user: `sa`
    * password: `@sdf1234` (in this case)

##

