using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
class CodPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        //Prac_3();
        Prac_4();
    }

    static void Prac_1()
    {
        Action[] actions = new Action[3];

        for (int i = 0; i < actions.Length; i++)
        {
            actions[i] = () => Console.Write(i);
        }
        foreach (Action a in actions)
        {
            a();
        }
        Console.WriteLine();
    }
    static void Prac_2()
    {
        Action[] actions = new Action[3];

        for (int i = 0; i < actions.Length; i++)
        {
            int loopVar = i;
            actions[i] = () => Console.Write(loopVar);
        }
        foreach (Action a in actions)
        {
            a();
        }
        Console.WriteLine();
    }
    static void Prac_3()
    {
        string[] names = { "김철수", "이영희", "박민수", "최지연" };
        Array.Sort(names, (a, b) => a.Length.CompareTo(b.Length));

        Console.WriteLine("이름 길이순 정렬:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("역순 정렬: ");
        Array.Sort(names, (a, b) => b.CompareTo(a));
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
    static void Prac_4()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int firstEven = numbers.Find(n => n % 2 == 0);
        Console.WriteLine($"첫 번째 짝수: {firstEven}");
        List<int> allEven = numbers.FindAll(n => n % 2 == 0);
        Console.WriteLine($"모든 짝수: {string.Join("," ,allEven)}");
        bool morNum = numbers.Exists(n => n > 8);
        Console.WriteLine($"8보다 큰 수 존재 : {morNum}");
        bool plusNum = numbers.TrueForAll(n => n > 0);
        Console.WriteLine($"모두 양수 : {plusNum}");
        int deleteNum = numbers.RemoveAll(n => n % 2 == 0);
        Console.WriteLine($"남은 숫자 {deleteNum}");
    }
}