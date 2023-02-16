/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int doublemass = Convert.ToInt32(Console.ReadLine());
int[,] numb = new int[doublemass, doublemass];

int minSum = Int32.MaxValue;
int indexx = 0;

void FindMinSum(int[,] numb)
{
    for (int i = 0; i < numb.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numb.GetLength(1); j++)
        {
            sum = sum + numb[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            indexx++;
        }
    }
    Console.WriteLine("Строка " + (indexx) + " с наименьшей суммой элементов.\nСумма элементов строки = " + (minSum));
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

FillArray(numb);
PrintArray(numb);
FindMinSum(numb);