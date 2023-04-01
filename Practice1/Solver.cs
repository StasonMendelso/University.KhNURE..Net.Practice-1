namespace Practice1;

public class Solver
{
    const double PI = 3.14;

    public void Task1()
    {
        PrintTaskHeader(1);
        int x1 = 100;
        Console.WriteLine("x1 = " + x1);
    }

    public void Task2()
    {
        PrintTaskHeader(2);
        string str1;
        Console.WriteLine("Ваше ім'я?");
        str1 = Console.ReadLine();
        string str2 = "Добрий день, " + str1;
        Console.WriteLine(str2);
    }

    public void Task3()
    {
        PrintTaskHeader(3);
        var v1 = 'v';
        v1 = 'w';
        Console.WriteLine("v1 = " + v1);
    }

    public void Task4()
    {
        PrintTaskHeader(4);
        Console.WriteLine("Введіть сторону квадрата:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Периметр квадрату дорівнює " + 4 * x);
    }

    public void Task5()
    {
        PrintTaskHeader(5);
        Console.WriteLine("Введіть перше число:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть друге число:");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Середнє арифметичне чисел дорівнює " + (x + y) / 2);
    }

    public void Task6()
    {
        PrintTaskHeader(6);
        Console.WriteLine("Введіть радіус першого круга:");
        double r1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть радіус другого круга:");
        double r2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Площа першого круга дорівнює " + CalculateCircleSquare(r1));
        Console.WriteLine("Площа другого круга дорівнює " + CalculateCircleSquare(r2));
        Console.WriteLine("Площа кільця дорівнює " + Math.Abs(CalculateCircleSquare(r1) - CalculateCircleSquare(r2)));
    }

    private double CalculateCircleSquare(double radius)
    {
        return PI * Math.Pow(radius, 2);
    }

    public void Task7()
    {
        PrintTaskHeader(7);
        Console.WriteLine("Введіть двозначне число:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x >= 10)
        {
            Console.WriteLine("Ліва цифра дорівнює " + x / 10);
        }
        else
        {
            Console.WriteLine("Лівої цифри немає");
        }

        Console.WriteLine("Права цифра дорівнює " + x % 10);
    }

    public void Task8()
    {
        PrintTaskHeader(8);
        Console.WriteLine("Введіть кількість секунд, що пройшло з початку доби:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Пройшло " + n / (60 * 60) + " повних годин");
    }

    public void Task9()
    {
        PrintTaskHeader(9);
        Console.WriteLine("Введіть число А:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть число B:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть число C:");
        int c = Convert.ToInt32(Console.ReadLine());
        if ((a < b && b < c) || (c < b && b < a))
        {
            Console.WriteLine("Число B знаходиться між числами A і C");
        }
        else
        {
            Console.WriteLine("Число B не знаходиться між числами A і C");
        }
    }

    public void Task10()
    {
        PrintTaskHeader(10);
        Console.WriteLine("Введіть ціле додатне число:");
        uint x = Convert.ToUInt32(Console.ReadLine());
        if (x % 2 == 1 && x is >= 100 and < 1000)
        {
            Console.WriteLine("Дане число є непарним трьохзначним.");
        }
        else
        {
            Console.WriteLine("Дане число не є непарним трьохзначним.");
        }
    }

    public void Task11()
    {
        PrintTaskHeader(11);
        int x1 = 10, x2 = 10;
        long sum = x1 + x2;
        Console.WriteLine("Сума двох змінних типу int в long: " + sum);
    }

    public void Task12()
    {
        PrintTaskHeader(12);
        long x1 = 10000, x2 = 100000;
        byte sum = (byte)(x1 + x2);
        Console.WriteLine("Сума двох змінних типу long в byte: " + sum);
    }

    private void PrintTaskHeader(int number)
    {
        Console.WriteLine("Task " + number);
    }
}