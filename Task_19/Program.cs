/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && Convert.ToString(result).Length == 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы не ввели пятизначное число. Повторите ввод!");
        }
    }

    return result;
}

void PalindromeCheck(int num)
{
    char[] numReverse = Convert.ToString(num).ToCharArray();
    Array.Reverse(numReverse);
    int newNum = Convert.ToInt32(new string(numReverse));
    if (num == newNum)
    {
        Console.WriteLine($"Число {num} - палиндром");
    }
    else
    {
        Console.WriteLine($"Число {num} - не палиндром");
    }
}

int num = GetNumber("Введите пятизначное число:");
PalindromeCheck(num);