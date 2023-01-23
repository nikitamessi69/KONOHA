﻿/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите число для размера массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
createArrayNum(numbers);
printArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

void createArrayNum(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void printArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] );
            if (i < numbers.Length - 1);
            {
                Console.Write(", ");
            }
        }
    Console.WriteLine("]");
}
Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");