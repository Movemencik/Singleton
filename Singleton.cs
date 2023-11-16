public sealed class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Hello from Singleton!");
    }
}