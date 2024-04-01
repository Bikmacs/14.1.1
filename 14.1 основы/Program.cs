using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите размерность 'Стека'");
            int capacity = int.Parse(Console.ReadLine()); // Исправление: правильное написание метода Parse

            // Вызываем метод Stack, передавая в него введенное значение capacity
            Stack(capacity);
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    // Метод Stack, который принимает в качестве параметра размерность стека
    static void Stack(int capacity)
    {
        Console.WriteLine("");
        Stack<int> stack = new Stack<int>();

        // Заполнение стека значениями от 1 до capacity, а не от 1 до неопределенной переменной n
        for (int i = 1; i <= capacity; i++)
        {
            stack.Push(i);
        }

        // Извлечение из стека и вывод на экран
        Console.WriteLine($"Размерность стека: {capacity}");
        while (stack.Count > 0)
        {
            int poppedValue = stack.Pop();
            Console.WriteLine(poppedValue);
        }
    }
}
