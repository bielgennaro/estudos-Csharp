﻿namespace ConsoleApp6;

internal class ConversaoImplicita
{
    static void Main(string[] args)
    {
        double a;
        int b;

        a = 5.1;
        b = (int)a;

        Console.WriteLine(b);
    }
}