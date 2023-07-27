namespace ConsoleApp31;

class Program
{
    static void Main(string[] args)
    {
        TimeSpan t1 = new TimeSpan(0, 1, 20);

        TimeSpan t2 = new TimeSpan(900000000L);

        TimeSpan t3 = new TimeSpan();

        TimeSpan t4 = new TimeSpan(1, 2, 11, 21);

        TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 300);

        TimeSpan t6 = TimeSpan.FromDays(1.5);
        TimeSpan t7 = TimeSpan.FromMinutes(1.5);
        TimeSpan t8 = TimeSpan.FromSeconds(1.5);
        TimeSpan t9 = TimeSpan.FromMilliseconds(1.5);
        TimeSpan t10 = TimeSpan.FromTicks(90000000L);
    }
}

