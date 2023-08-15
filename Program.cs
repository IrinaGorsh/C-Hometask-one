// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = 5;
int b = 7;
if(a > b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"Число {a} меньше числа {b}");
}


 //   Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    {
        Console.Write("x1 = 44");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("x2 = 5");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("x3 = 78");
        double x3 = Convert.ToDouble(Console.ReadLine());

        var max = x1;
        if (max < x2)
        {
            max = x2;
        }

        if (max < x3)
        {
            max = x3;
        }

        Console.WriteLine($"Максимальное из чисел {x1}, {x2}, {x3} равно {max}");
        Console.ReadLine();
    }


