# .Net-GraphQL-HotChocolate
## Motivation for GraphQL
To add a new API call you don’t need to rewrite it on backend.
Technology undefended Node, Go, Scala etc… No matter how the RestAPI was written, you just consume the API.

### Requirements For Frontend 

Architect to make GraphQL work with ReactJS. Which client library do we choose. Apollo is dominating GraphQL client environment. Cash on Client’s side should be improved.  
! Do not fatch all data at once. Try to catch step by step in order to have fast responses 

### How GraphQL works
Graphical = GraphQL IDE
Sending “graphical document” to server, sever executes, sends back JSON
Having ability to explore graph of data types.
Querying.

* Request (GraphQL doc) -> Response (JSON)
* Language Specification
* Schema
* Server implementation

### What GraphQL is not
* ! Client-side state management
* ! Good for streaming
* ! Facebook Graph APII
* ! Limited to specific DB (no DB needed)
* ! Limited to JS/NodeJS on Backend
* ! Limited to React/Web
* ! Limited to HTTP (transport layers)

### GraphQL Functionality
* Query - Read  
* Mutation - Write  
* Subscription - Observe Event, creates  a persistent connection between the client and server. Whenever specific event triggers, and data is pushed back to the client. Needed to build ChatApp, Transportation, Communication apps.

Syntax:
```
query GetBooksForAuthor($id: ID!){
	author(id:$id){
		name,
		nationality,
		books{
			title
			isbn
		}
	}
}
```
### Modern Challenges
Efficiency: 

* Overfetching- contains too much data
* Underfetching- not enough data at one req


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
    * Will be needed later `dotnet tool install --global dotnet-ef`

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

## Database
It is assumed that you got the code files properly. `dotnet run` compiles and runs the script. `http://localhost:5000/graphql/` is the location of GraphQL GUI kinda thing, where you can query. Before querying add some data into `Platform` table:
```sql
SET IDENTITY_INSERT Platforms ON

INSERT INTO Platforms
   ([Id],[Name],[LicenseKey])
VALUES
   ( 1, N'Jared', N'123'),
   ( 2, N'Nikita', N'234'),
   ( 3, N'Tom', N'345'),
   ( 4, N'Jake', N'456')
GO

```
In order to get alist of `Platforms` table run sample query:
```
query{
  platform{
    id,
    name
  }
}
```

[Source](https://www.youtube.com/watch?v=HuN94qNwQmM)