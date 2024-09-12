using System;

class Program
{
    static void Main()
    {
        // Инициализация генератора случайных чисел
        Random rand = new Random();
        
        // Объявление массивов для a и b
        double[] a = new double[20];
        double[] b = new double[20];

        // Заполнение массивов случайными числами от 0 до 100
        for (int i = 0; i < 20; i++)
        {
            a[i] = rand.NextDouble() * 100; // случайное число от 0 до 100
            b[i] = rand.NextDouble() * 100; // случайное число от 0 до 100
        }

        // Вычисление сумм (a[i] + b[20-i]) и вывод результатов
        for (int i = 0; i < 20; i++)
        {
            double sum = a[i] + b[19 - i]; // a[i] + b[20-i] (индексация с 0)
            Console.WriteLine($"Сумма a[{i + 1}] + b[{20 - i}] = {sum:F2}");
        }
    }
}