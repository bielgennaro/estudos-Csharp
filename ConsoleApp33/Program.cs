namespace ConsoleApp33;

class Program
{
    static void Main(string[] args)
    {
        TimeSpan t1 = TimeSpan.MaxValue;
        TimeSpan t2 = TimeSpan.Zero;
        TimeSpan t3 = TimeSpan.MinValue;

        TimeSpan t = new TimeSpan();

        Console.WriteLine("Days: " + t.Days);
        Console.WriteLine("Seconds: " + t.Seconds);
    }
}

