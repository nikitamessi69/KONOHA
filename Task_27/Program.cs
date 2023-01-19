/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int getUserNumb, sum;
Console.Write("Введите число: ");
getUserNumb =Convert.ToInt32(Console.ReadLine());

sum = 0;
while(getUserNumb != 0)
{
    sum += getUserNumb % 10;
    getUserNumb /= 10;

}
Console.WriteLine($"Сумма цифр числа = {sum}");