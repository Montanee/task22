using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
            return;
        }

        if (number >= 5 && number <= 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }
    }
}
