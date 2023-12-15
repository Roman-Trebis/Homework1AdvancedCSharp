using System;

/* 
 * Задание 1.
 * 1. Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.
 *
*/

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите выражение вида a + b, a - b, a / b, a * b:");
        string input = Console.ReadLine();

        char[] delimiters = { '+', '-', '/', '*' };
        string[] tokens = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        char operation = input.FirstOrDefault(c => c == '+' || c == '-' || c == '/' || c == '*');

        if (tokens.Length != 2 || operation == '0')
        {
            Console.WriteLine("Неверный формат выражения");
            return;
        }

        if (!double.TryParse(tokens[0], out double a) || !double.TryParse(tokens[1], out double b))
        {
            Console.WriteLine("Неверный формат чисел");
            return;
        }

        double result = 0;
        switch (operation)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '/':
                result = a / b;
                break;
            case '*':
                result = a * b;
                break;
            default:
                break;
        }

        Console.WriteLine("Результат: " + result);
    }
}