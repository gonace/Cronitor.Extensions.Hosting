# Cronitor.Extensions.Hosting
Hosting and startup abstractions for Cronitor. When using NuGet 3.x this package requires at least version 3.4....

## Usage
```c#
await Host.CreateDefaultBuilder()
    .UseCronitor("apiKey")
    .Build()
    .RunAsync();
```
