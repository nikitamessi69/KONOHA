/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7: ");
int HolNum = Convert.ToInt32(Console.ReadLine());

if (HolNum >= 1 && HolNum <= 7)
{
    if (HolNum == 6 || HolNum == 7) 
    {
        Console.WriteLine("Выходной день");
    }
    else 
    {
        Console.WriteLine("Будний день");
    }
}    
