namespace Singleton.ThreadSafe;

/// <summary>
/// Thread safe singleton class
/// </summary>
public class Counter
{
    /// <summary>
    /// Creates a new instance of <see cref="Counter"/>
    /// </summary>
    /// <remarks>Constructor is protected so that class can be extended but not instantiated</remarks>
    protected Counter() { }

    /// <summary>
    /// Returns the count with a private setter
    /// </summary>
    public int Count { get; private set; } = 0;

    /// <summary>
    /// Instance of Lazy of <see cref="Counter"/>
    /// </summary>
    private static readonly Lazy<Counter> _instance = new(() => new Counter());

    /// <summary>
    /// Returns the same/single instance of this class
    /// </summary>
    public static Counter Instance => _instance.Value;

    /// <summary>
    /// The singleton operation
    /// </summary>
    public void Add() => Count++;

}
