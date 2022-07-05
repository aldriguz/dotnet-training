# Commands

Create proto file
```
dotnet new proto -n ProductsService --namespace ServicesProto
```

List packages Nuget installed
```
dotnet list package
```

Adding packages for client
```
dotnet add package 
```

# Steps for build server
1. Create the protos
2. Reference to the services
3. Registrer to the IoC container