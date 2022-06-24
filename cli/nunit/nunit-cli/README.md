### Create test project
The name is taken from subfolder where command executed, this `nunit` command will create an NUnit test project, same applies to xUnit
```
dotnet new nunit
```

### Create with name
This creates with custom name and also `--name` is the same as `-n` attribute.
```
dotnet new nunit --name 'nunit-cli' 
```

### Solution commands

#### Create a solution


#### Adding a project to solution 
The command should be executed in path where lives the `.sln` file, in case you have multiple solutions you can pass the name of the solution.
In this example we add the `nunit-cli` project to the solution called `NET.Training`

```
dotnet sln .\NET.Training.sln add .\cli\nunit\nunit-cli\nunit-cli.csproj
```


### References
- https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln
