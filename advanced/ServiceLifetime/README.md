# Introduction
This is the most common queustion for .NET interviews I think, and also must known for devs.

## Instructions

Go to `base_route/lifetime` and press F5 several times to see the results
There will be two instances defined and will be instanciated in different places over NET request lifecycle.

Dependency: ticks value
Middleware: ticks value


### Transient

The values will be different all the time

### Scoped

Every time you refresh the page the values will change.

### Singleton

Ticks value should not change even you refresh the page.

## References
- https://henriquesd.medium.com/dependency-injection-and-service-lifetimes-in-net-core-ab9189349420
- https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection#service-lifetimes
