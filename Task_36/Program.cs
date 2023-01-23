/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Ввести число для размера массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
createArrayNum(numbers);
printArray(numbers);
int sum = 0;

void createArrayNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-30,30);
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
for (int i = 0; i < numbers.Length; i += 2)
    sum += numbers[i];

    Console.WriteLine($"У нас {numbers.Length} нечетных числа, сумма чисел = {sum}");