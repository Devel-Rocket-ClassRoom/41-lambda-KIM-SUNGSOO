using System;
using System.Runtime.InteropServices;
using System.Xml;


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
        PrintMessage hello = () => Console.WriteLine("안녕하세요");

        hello();

    }

    static void Prac_2()
    {
        Transformer square = x => x * x;

        Console.WriteLine(square(3));
        Console.WriteLine(square(4));
        
    }

    static void Prac_3()
    {
        IsLonger isLong = (string msg, int len) => msg.Length > len;
        Console.WriteLine(isLong("안녕하세요.", 5));
        Console.WriteLine(isLong("반갑습니다.", 10));
    }

    static void Prac_4()
    {
        Greeting greet = () =>
        {
            Console.WriteLine("안녕하세요.");
            Console.WriteLine("반갑습니다.");
        };
        greet();
    }

    static void Prac_5()
    {
        Calculator add = (a, b) =>
        {
            int result = a + b;
            Console.WriteLine($"{a} + {b} = {result}");
            return result;
        };

        int sum = add(3, 5);
        Console.WriteLine($"합계: {sum}");
    }
}

