using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Singleton.IoC;

Console.Title = "Singleton.IoC";

// Setup IoC and register service
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<Counter>();
using IHost host = builder.Build();

Counter instance1 = host.Services.GetService<Counter>()!;
Counter instance2 = host.Services.GetService<Counter>()!;

// Check if the instances are actually the same instance
if (instance1 == instance2)
{
    Console.WriteLine("They are the same instance!");
}
Console.WriteLine();

// Execute Singleton Operation from one instance and read from the other
Console.WriteLine($"Execute singleton operation from {nameof(instance1)}");
instance1.Add();
Console.WriteLine($"The count is from {nameof(instance2)}: {instance2.Count}");
Console.WriteLine();

Console.WriteLine($"Execute singleton operation from {nameof(instance2)}");
instance2.Add();
Console.WriteLine($"The count is from {nameof(instance1)}: {instance1.Count}");

Console.ReadLine();