/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

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

string GetValues(int n, int m)
{
    if (n == m)
    {
        return n.ToString();
    }
    return GetValues(n - 1, m) + $", {n}";
}


int m = GetNumber("Введите число больше m больше 1");
int n = GetNumber("Введите число больше m");

int Summ(int n, int m)
{
    int result = 0;
    if (n < m)
    {
        return result;
    }
    else
    {
        return Summ(n-1,m) + n ;
    }
    return result;
}

GetValues(n,m);
Console.WriteLine(GetValues(n, m));

int summ = Summ(n,m);
Console.WriteLine($"{summ}");
