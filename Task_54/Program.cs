/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.Clear();

Console.WriteLine("Введите количество строк: ");
int rowArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colArray = Convert.ToInt32(Console.ReadLine());

int[,] descendNum = new int[rowArray, colArray];
Console.WriteLine();
Console.WriteLine("|Заданный массив|");
FillArray(descendNum);
PrintArray(descendNum);


void DescendArray(int[,] descendNum)
{
    for (int i = 0; i < descendNum.GetLength(0); i++)
    {
        for (int j = 0; j < descendNum.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < descendNum.GetLength(1) - 1; k++)
            {
                if (descendNum[i, k] < descendNum[i, k + 1])
                {
                    int temp = 0;
                    temp = descendNum[i, k];
                    descendNum[i, k] = descendNum[i, k + 1];
                    descendNum[i, k + 1] = temp;
                }
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("|Массив с элементами по убыванию|");
DescendArray(descendNum);
PrintArray(descendNum);


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



