/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int getNumber;
Console.WriteLine("Будет создан массив");
Console.Write("Введите любое число: ");
getNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[getNumber];

for (int i = 0; i < getNumber; i++)
{
    array[i] = new Random().Next(getNumber+1);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();