using System;

public class Program
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("Ввести переменные a: ");
        a=int.Parse(Console.ReadLine());
        Console.WriteLine("Ввести переменные b: ");
        b=int.Parse(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("Переменная a: " + a);
        Console.WriteLine("Переменная b: " + b);
        Console.WriteLine();

        double c, d;
        Console.WriteLine("Ввести переменные c: ");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Ввести переменные d: ");
        d = int.Parse(Console.ReadLine());
        double ans = (c + d) / 2 + Math.Abs((c - d) / 2);
        Console.WriteLine("Максимальное: " + ans);
        Console.WriteLine();

        int p,l,m,n,otv;
        Console.WriteLine("Ввести расстояние p от грядки до колодца:");
        p = int.Parse(Console.ReadLine());
        Console.WriteLine("Ввести высоту l грядки:");
        l = int.Parse(Console.ReadLine());
        Console.WriteLine("Ввести ширину m грядки:");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Ввести количество n грядок:");
        n = int.Parse(Console.ReadLine());
        otv = (p + m * 2 + l * 2 + l * (n - 1) + p)*n;
        Console.WriteLine(otv);
    }
}

