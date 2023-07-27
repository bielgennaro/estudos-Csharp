using System.Globalization;

namespace ConsoleApp30;

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = DateTime.Parse("2000-12-2");
        DateTime d2 = DateTime.Parse("2000-12-2 13:00");

        DateTime d3 = DateTime.Parse("15/08/2003");

        DateTime d4 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        DateTime d5 = DateTime.ParseExact("15/06/2003 06:04:23", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        
    }
}