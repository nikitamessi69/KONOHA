/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Ввести число для размера массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
createArrayNum(numbers);
printArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"У нас {numbers.Length} чисел, количество четных - {count}");

void createArrayNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void printArray(int[] numbers)
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