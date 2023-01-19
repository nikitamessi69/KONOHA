/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int numA, numB, degree;
Console.Write("Ввести число А: ");
numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести число B: ");
numB = Convert.ToInt32(Console.ReadLine());

degree = numA;
for(int i = 2; i <= numB; i++)
{
    degree *= numA;
}
 Console.WriteLine($"{numA}^{numB} = {degree}");