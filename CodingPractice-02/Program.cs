using System;

// README.md를 읽고 아래에 코드를 작성하세요.

class CodPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        Prac_3();
    }

    static void Prac_1()
    {
        Func<int> getNumber = () => 1234;
        Console.WriteLine(getNumber());

        Func<int, int> square = x => x * x;
        Console.WriteLine(square(3));

        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(3, 5));
    }

    static void Prac_2()
    {
        Action action = () => Console.WriteLine("안녕하세요!");
        action();
        Action<string> print = message => Console.WriteLine(message);
        print("Hello Lambda!");
        Action<string, int> repeat = (msg, count) =>
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(msg);
            }
        };
        repeat("반복", 3);

    }

    static void Prac_3()
    {
        Func<int, int> Num = delegate (int x) { return x * x; };
        Console.WriteLine(Num(2));
        Func<int, int> Lambda = x => x * x;
        Console.WriteLine(Lambda(2));

    }

}
