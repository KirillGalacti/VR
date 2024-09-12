using System;
class Program{
    static void Main(string[] args){
        //Первая переменая
        Console.Write("Введите значение i:");
        double i = Convert.ToDouble(Console.ReadLine());
        //Вторая переменная
        Console.Write("Введите значение a:");
        double a = Convert.ToDouble(Console.ReadLine());
        //Результат выражения
        double e;

        //Проверка условий для вычисления выражения
        if(i % 2 !=0 && a > 0){//i - нечетное, a > 0
            e = i * Math.Sqrt(a);
        }else if(i % 2 == 0 && a < 0){//i - четное, a < 0
            e = i/2 * Math.Sqrt(Math.Abs(a));
        }else{//Иначе
            e = Math.Sqrt(Math.Abs(i*a));
        }

        //Вывод результата выражения
        Console.WriteLine($"Результат вычисления: e = {e}");
    }
}