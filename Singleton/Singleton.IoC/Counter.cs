namespace Singleton.IoC;

/// <summary>
/// Thread safe singleton class
/// </summary>
public class Counter
{
    /// <summary>
    /// Returns the count with a private setter
    /// </summary>
    public int Count { get; private set; } = 0;

    /// <summary>
    /// The singleton operation
    /// </summary>
    public void Add() => Count++;

}

