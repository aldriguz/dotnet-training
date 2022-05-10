# Mongo Catalog Web Api using .NET 5


## Architecture

Simple Data-Driven for CRUD solution using MonboDB, estructured in folders.
N-Layers: API Layer, Domain Model Layer, Data Layer (Repositories)

## Packages

* Swashbuckle.AspNetCore
* MongoDB.Driver

## Features
* API design good practices
* Catalog CRUD operations
* Health check
* Repository pattern for data access
* Swagger UI
* Initial data seed

## Create database
Once inside docker container for mongo type this commands
```C#
use CatalogDb
db.createCollection('Products')
```