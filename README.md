\# Task Management API



A RESTful Web API built with \*\*ASP.NET Core, C#, Entity Framework Core, and SQL Server\*\* to manage tasks.



\## Features



\- Retrieve all tasks.

\- Create a new task.

\- Delete a task by ID.

\- Store task data in SQL Server.

\- Test API endpoints using Swagger.

\- Validate task titles and descriptions.



\## Technologies Used



\- C#

\- ASP.NET Core Web API

\- Entity Framework Core

\- SQL Server Express

\- Swagger / OpenAPI

\- Visual Studio



\## API Endpoints



| Method | Endpoint | Description |

|---|---|---|

| GET | `/api/Tasks` | Retrieve all tasks |

| POST | `/api/Tasks` | Create a new task |

| DELETE | `/api/Tasks/{id}` | Delete a task by ID |



\## Example: Create a Task



\*\*POST\*\* `/api/Tasks`



```json

{

&#x20; "title": "Learn ASP.NET Core",

&#x20; "description": "Build my first API project",

&#x20; "isCompleted": false

}

```



\## Database Configuration



This project uses SQL Server Express with Entity Framework Core.



Update the connection string in `appsettings.json` to match your local SQL Server configuration.



\## How to Run



1\. Clone or download the repository.

2\. Open the project in Visual Studio.

3\. Configure the SQL Server connection string.

4\. Apply the database migrations if needed.

5\. Run the application.

6\. Open the Swagger page to test the endpoints.



\## Author



\*\*Moataz Madyan\*\*



