using Singleton.Simple;

Console.Title = "Singleton.Simple";

// Get two "instances"
var instance1 = Counter.Instance;
var instance2 = Counter.Instance;

// Check if the instances are actually the same instance
if (instance1 == instance2 
    && instance1 == Counter.Instance
    && instance2 == Counter.Instance)
{
    Console.WriteLine("They are all the same instance!");
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