/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();
int c = 5;
int r = 5;
int[,] array = new int[c, r];

void FillArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElementArray(int[,] findElement, int userNum)
{
    bool find = false;
    for (int i = 0; i < findElement.GetLength(0); i++)
    {
        for (int j = 0; j < findElement.GetLength(1); j++)
        {
            if (findElement[i, j] == userNum)
                Console.WriteLine("Искомый элемент расположен в координатах " + j + " " + i);
            find = true;
            if (find == false)
            Console.WriteLine("Такого числа в массиве нет!");
        }
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
FillArray(array);
FindElementArray(array, num);