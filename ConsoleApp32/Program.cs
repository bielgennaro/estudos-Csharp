namespace ConsoleApp32;

class Program
{
    static void Main(string[] args)
    {
        DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

        Console.WriteLine("1) Day: " + d.Day);
        Console.WriteLine("2) Month: " + d.Month);
        Console.WriteLine("3) Year: " + d.Year);

        Console.WriteLine(d.ToLongDateString());
        Console.WriteLine(d.ToShortDateString());
        Console.WriteLine(d.ToLongTimeString());

        string s6 = d.ToString("yyyy-M-d dddd");

        DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
        DateTime d2 = d.AddHours(2);
        DateTime d3 = d.AddDays(7);
    }
}

