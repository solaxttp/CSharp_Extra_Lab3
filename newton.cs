using System;

class Program
{
    static double f(double x) => x * x - 2;   // Рівняння: x^2 - 2 = 0
    static double df(double x) => 2 * x;      // Похідна: 2x

    static void Main()
    {
        double x = 1;          // Початкове наближення
        double eps = 0.0001;   // Точність

        double x_prev;
        int iter = 0;

        do
        {
            x_prev = x;
            x = x_prev - f(x_prev) / df(x_prev);
            iter++;
        }
        while (Math.Abs(x - x_prev) > eps);

        Console.WriteLine("Метод Ньютона:");
        Console.WriteLine($"Корінь ≈ {x}");
        Console.WriteLine($"Кількість ітерацій: {iter}");
    }
}
