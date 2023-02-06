/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число < 0. Повторите ввод!");
        }
    }

    return result;
}

void GetCube(int n)
{
    for (int i = 1; i <= n; i++)
    {
        double nCube = Math.Pow(i, 3);
        Console.WriteLine($"{i}\t{nCube}");
    }
}

int n = GetNumber("Введите число N:");
Console.WriteLine($"Таблица кубов чисел от 1 до {n}: ");
Console.WriteLine("Число\tКуб");
GetCube(n);