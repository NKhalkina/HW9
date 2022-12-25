/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 1)
        {
            break;
        }
        else
        {
            Console.WriteLine(" Ввели число меньше или равно 1");
        }
    }
    return result;
}

string GetValues(int n)
{
    if (n == 1)
    {
        return n.ToString();
    }
    return  $"{n}," + GetValues(n - 1);
}

int n = GetNumber("Введите число больше 1");

GetValues(n);
Console.WriteLine(GetValues(n));