using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;


class CodPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        //Prac_3();
        //Prac_4();
        Prac_5();
    }


    static void Prac_1()
    {
        var multiplesOf3 = FindNumbers(n => n % 3 == 0);
        Console.WriteLine("3의 배수:");
        foreach (var n in multiplesOf3)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();

        var perfectSquares = FindNumbers(n =>
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        });
        Console.WriteLine("제곱수:");
        foreach (var n in perfectSquares)
        {
            Console.Write($"{n} ");
        }
        static List<int> FindNumbers(Predicate<int> predicate)
        {
            List<int> results = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (predicate(i))
                {
                    results.Add(i);
                }
            }
            return results;
        }
    }

    static void Prac_2()
    {
        Predicate<int> predicate = n => n % 2 == 0;
        Func<int, bool> isadd = n => n % 2 == 1;
        Console.WriteLine(predicate(4));
        Console.WriteLine(isadd(4));
        
    }

    static void Prac_3()
    {
        int factor = 2;
        Func<int, int> multipler = n => n * factor;
        Console.WriteLine(multipler(3));

        factor = 10;
        Console.WriteLine(multipler(3));

    }
    static void Prac_4()
    {
        int count = 0;
        Action increment = () => count++;
        increment();
        increment();
        increment();

        Console.WriteLine(count);
    }
    static void Prac_5()
    {
        var count = CreateCounter();
        Console.WriteLine(count());
        Console.WriteLine(count());
        Console.WriteLine(count());


        static Func<int> CreateCounter()
        {
            int count = 0;
            return () => count++;
        }
    }
}

