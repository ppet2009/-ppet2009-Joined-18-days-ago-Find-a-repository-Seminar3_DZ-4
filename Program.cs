/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

double Number (double a, double b)
{
    return Math.Pow (a , b);
}
Console.WriteLine("Input a");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b");
double b = Convert.ToInt32(Console.ReadLine());
double result = Number(a, b);
Console.WriteLine($" Ответ = {result}");
