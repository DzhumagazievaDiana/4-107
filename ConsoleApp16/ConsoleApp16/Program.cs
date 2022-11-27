using System;
public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("порядковый номер месяца", 1, 12);
        var a = int.Parse(Console.ReadLine());
        Console.WriteLine("Это високосный год?");
        Console.WriteLine("1 если Да, 0 если Нет", 0, 1);
        var b = int.Parse(Console.ReadLine());
        int c = 0;
        switch (a)
        {
            case 1: c = 31; break;
            case 2: if (b == 1) c = 29; else c = 28; break;
            case 3: c = 31; break;
            case 4: c = 30; break;
            case 5: c = 31; break;
            case 6: c = 30; break;
            case 7: c = 31; break;
            case 8: c = 31; break;
            case 9: c = 30; break;
            case 10: c = 31; break;
            case 11: c = 30; break;
            case 12: c = 31; break;
        }
        Console.WriteLine($"В этом месяце {c} дней");
        Console.ReadKey();
    }
}
