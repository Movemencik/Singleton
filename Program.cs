class Program
{
    static void Main()
    {
        Singleton singleton1 = Singleton.Instance;
        singleton1.DisplayMessage();

        Singleton singleton2 = Singleton.Instance;
        singleton2.DisplayMessage();

        Console.WriteLine($"singleton1 == singleton2: {singleton1 == singleton2}");

        Console.ReadLine();
    }
}