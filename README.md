### P.U.L.S.E. - Personal Utility List & Scheduling Engine

## Features

- Controller-based REST API
- Swagger documentation
- In-memory data storage
- Async service design
- Input validation
- Proper HTTP status codes


## Technologies

- C#
- ASP.NET Core Web API
- Swagger UI for API documentation and testing
- OpenAPI specification

## How to Run

1. **Build the project**:
   ```bash
   dotnet build
   ```

2. **Run the server**:
   ```bash
   dotnet run --project aspnetintro/aspnetintro.csproj
   ```

## Testing API Endpoints using swagger

1. The API can be tested manually using Swagger UI.
    ```bash
    http://localhost:5179/swagger/index.html
    ```

or using cURL / Postman / HTTPie with
    ```bash
    http://localhost:5179/api/tasks/
    ```

2. Test the endpoints:
- `GET /api/tasks` - Verify that tasks can be retrieved.
- `GET /api/tasks/{id}` - Verify that a single task can be retrieved.
- `POST /api/tasks` - Create a new task and verify that the API returns `201 Created`.