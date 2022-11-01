/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/
/*
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
*/

/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/

/*

int FindSum(int num)
{   
    int size = Convert.ToString(num).Length;
    int ed = 0;
    int findSum = 0;
    for(int i = 0; i < size; i++)
    {   
        ed = num - num % 10;
        findSum = findSum + (num - ed);
        num = num / 10;
    }
    return findSum;
}
Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int findSum = FindSum(num);
Console.WriteLine($"сумма цифр в числе = {findSum}");

*/

