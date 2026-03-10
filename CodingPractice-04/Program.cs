using System;
using System.Collections.Generic;

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

    }
}