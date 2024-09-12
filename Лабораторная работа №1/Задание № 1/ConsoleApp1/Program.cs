using System;
using System.Data;

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение x:");
        double x; 
        while (!double.TryParse(Console.ReadLine(), out x) || x < 0)
        {
            Console.WriteLine("Некорректное значение. Введите положительное число!");
        }


        Console.WriteLine("Введите значение y (от -1 до 1):");
        double y;
        while (!double.TryParse(Console.ReadLine(), out y) || y < -1 || y > 1)
        {
            Console.WriteLine("Некорректное значение. Введите число от -1 до 1!");
        }

        double g;
        
        double divisible = 1 + Math.Cos(x + y);
        double divider = Math.Abs(Math.Exp(x) - (2 * y / (1 + Math.Pow(x, 2) + Math.Pow(y, 2))));
        g = divisible/divider * Math.Pow(x, 3) + Math.Asin(y);

        if(divider == 0){
            Console.WriteLine("Знаминатель оказался равнным нулю. Невозможно выполнить деление.");
            return;  // Выход из приложения при нулевом знаминателе
        }

        Console.WriteLine($"Результат вычиления: g = {g}");
    }
}
