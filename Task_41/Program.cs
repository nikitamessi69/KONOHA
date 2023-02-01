/*
*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int[] CreateMassive(int M)
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        array[i] = GetDataFromUser($"\nВведите с клавиатуры: {i} - элемент: ");
    }
    return array;
}

void printArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("[");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("]");
    Console.ResetColor();
}

int FillNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
            count = count + 1;
    }
    return count;
}

int size = GetDataFromUser("\nУстановите размер массива: ");
int[] array = CreateMassive(size);
printArray(array);
int number = FillNumber(array);
Console.WriteLine($"\nКоличество чисел больше 0 = {number}" + ".");