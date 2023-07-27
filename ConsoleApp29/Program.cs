using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp29;

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = new DateTime(2018, 11, 25);
        DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
        DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

        DateTime d4 = DateTime.Now;
        DateTime d5 = DateTime.Today;
        DateTime d6 = DateTime.UtcNow;
        
        Console.WriteLine(d1);
    }
}