# AspNet-DI for Discord.Net #

A simple wrapper to enable users of ASP.NET Dependency Injection to use
Discord.Net without changing their project structure

## Usage ##

Assuming you already have an IServiceProvider setup, using this code should be
as simple as creating an `AspNetDependencyMap`. For example:

```cs
IServiceProvider provider = serviceCollection.Build();
IDependencyMap serviceMap = new AspNetDependencyMap(provider);

// Use the serviceMap object in Discord.Net normally
```