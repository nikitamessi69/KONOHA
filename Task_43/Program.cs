/*
*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (k1 == k2)
    {
        Console.Write("\nВаши прямые не пересекаются в заданной системе координат!");
    }
    else
    {
        Console.Write($"\nТочка пересечения двух прямых в заданной системе координат: ({x}; {y})" + ".");
    }
}

int b1 = GetDataFromUser("\nВведите переменную b1: ");
int k1 = GetDataFromUser("\nВведите переменную k1: ");
int b2 = GetDataFromUser("\nВведите переменную b2: ");
int k2 = GetDataFromUser("\nВведите переменную k2: ");
IntersectionPoint(k1, b1, k2, b2);