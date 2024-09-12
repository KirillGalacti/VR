using System;

class Program
{
    static void Main()
    {
        // Инициализация генератора случайных чисел
        Random rand = new Random();
        
        // Создание матрицы Z размером 5x6
        int rows = 5, cols = 6;
        int[,] Z = new int[rows, cols];
        int[] B = new int[cols]; // Массив для хранения отрицательных элементов
        bool[] replaced = new bool[cols]; // Для отслеживания замены в каждом столбце

        // Заполнение матрицы случайными числами от -50 до 50
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Z[i, j] = rand.Next(-50, 51); // Случайное число от -50 до 50
            }
        }

        // Вывод исходной матрицы
        Console.WriteLine("Исходная матрица Z:");
        PrintMatrix(Z, rows, cols);

        // Проход по столбцам для поиска и замены первого отрицательного элемента
        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                if (Z[i, j] < 0 && !replaced[j]) // Первый отрицательный элемент
                {
                    B[j] = Z[i, j]; // Сохранение элемента в массив B
                    replaced[j] = true;

                    // Подсчет суммы оставшихся элементов столбца
                    int sum = 0;
                    for (int k = 0; k < rows; k++)
                    {
                        if (k != i) // Пропускаем заменяемый элемент
                            sum += Z[k, j];
                    }

                    Z[i, j] = sum; // Замена отрицательного элемента на сумму
                    break;
                }
            }
        }

        // Вывод массива B с отрицательными элементами
        Console.WriteLine("\nМассив B с отрицательными элементами до замены:");
        for (int j = 0; j < cols; j++)
        {
            Console.Write(B[j] + "\t");
        }
        Console.WriteLine();

        // Вывод преобразованной матрицы
        Console.WriteLine("\nПреобразованная матрица Z:");
        PrintMatrix(Z, rows, cols);
    }

    // Метод для печати матрицы
    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
