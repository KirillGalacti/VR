using System;

class Program
{
    static void Main()
    {
        // Инициализация первых значений
        double x1 = 0.7; 
        double y1 = 0.4;
        double x2 = 0.65;
        double y2 = 0.5;

        // Начальные максимумы и минимумы
        double maxX = Math.Max(x1, x2);
        double minY = Math.Min(y1, y2);

        // Вывод первых двух значений
        Console.WriteLine($"x1 = {x1}, y1 = {y1}");
        Console.WriteLine($"x2 = {x2}, y2 = {y2}");

        // Переменные для хранения предыдущих значений
        double xPrev1 = x1;
        double yPrev1 = y1;
        double xPrev2 = x2; 
        double yPrev2 = y2; 

        // Вычисление последовательностей для i = 3, 4,..., 15
        for (int i = 3; i <= 15; i++)
        {
            // Вычисление x_i и y_i
            double xi = xPrev1 + xPrev2 - 0.6 * yPrev1;
            double yi = yPrev2 + 0.2 * xPrev2;

            // Обновление максимума для x и минимума для y
            if (xi > maxX)
            {
                maxX = xi;
            }
            if (yi < minY)
            {
                minY = yi;
            }

            // Вывод значений
            Console.WriteLine($"x{i} = {xi}, y{i} = {yi}");

            // Сдвиг значений для следующего шага
            xPrev2 = xPrev1;
            xPrev1 = xi;
            yPrev2 = yPrev1;
            yPrev1 = yi;
        }

        // Вывод максимального x и минимального y
        Console.WriteLine($"\nМаксимальное значение x_i: {maxX}");
        Console.WriteLine($"Минимальное значение y_i: {minY}");
    }
}