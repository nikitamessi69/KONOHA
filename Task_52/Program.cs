/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] RowCol = new int[row, col];

void AverageArray(int[,] RowCol)
{
    for (int j = 0; j < RowCol.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < RowCol.GetLength(0); i++)
        {
            average = (average + RowCol[i, j]);
        }
        average = average / row;
        Console.Write(average + "; ");
    }
}
Console.WriteLine();

void FillArrayRowCol(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

FillArrayRowCol(RowCol);
PrintArray(RowCol);
AverageArray(RowCol);