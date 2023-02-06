/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод!");
        }
    }

    return result;
}

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    double result = Math.Round(dist, 2);
    return result;
}

int x1 = GetNumber("Введите значение x1:");
int y1 = GetNumber("Введите значение y1:");
int z1 = GetNumber("Введите значение z1:");
int x2 = GetNumber("Введите значение x2:");
int y2 = GetNumber("Введите значение y2:");
int z2 = GetNumber("Введите значение z2:");

double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками A и B в 3D пространстве = {distance}");