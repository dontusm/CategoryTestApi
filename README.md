# Category Test API

## Installation

### 1. Clone the Repository:
```bash
git clone https://github.com/your-repo/CategoryTestApi.git
cd CategoryTestApi
```

### 2. Configure the Database Connection:
Update the `appsettings.json` file with your SQL Server instance:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=CategoriesDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

or set `"Server=.\SQLEXPRESS"`.

### 3. Run the Application:
Start the API with:

```bash
dotnet run
```

### 4. Access the API:
Once the application is running, you can access:

- **Swagger UI**: [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html)  
- **Get Objects by Category**:  
  ```http
  GET http://localhost:5000/api/objects/by-category/{categoryId}
  ```