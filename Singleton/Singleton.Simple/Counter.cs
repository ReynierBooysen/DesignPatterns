namespace Singleton.Simple;

/// <summary>
/// Simple singleton class
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
    /// Nullable backing field so that we can check if the instance is null
    /// </summary>
    private static Counter? _instance;

    /// <summary>
    /// Returns the same/single instance of this class
    /// </summary>
    public static Counter Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new Counter();
            }
            return _instance;
        }
    }

    /// <summary>
    /// The singleton operation
    /// </summary>
    public void Add() => Count++;

}
