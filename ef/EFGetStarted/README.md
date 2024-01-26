Commands in order

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

Create database

```
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update
```

Run the code to make changes on database

```
dotnet run```