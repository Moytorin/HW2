// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int number = new Random().Next(100,1000);
Console.WriteLine($"Трехзначное число = {number}");
int num1 = number / 10;
int num2 = num1 % 10;
Console.WriteLine($"Второе число = {num2}");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
645 -> 5
78 -> третьей цифры нет
32679 -> 6 
*/

/*
int number = new Random().Next(10,100000);
Console.WriteLine($"Число равно {number}");
if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if((number >= 100) && (number < 1000))
{
    int num1 = number % 10;
    Console.WriteLine($"{num1}");
}
if((number >= 1000) && (number < 10000))
{
    int num2 = number / 10;
    int num3 = num2 % 10;
    Console.WriteLine($"{num3}");
}
if((number >= 10000) && (number < 100000))
{
    int num4 = number / 100;
    int num6 = num4 % 10;
    Console.WriteLine($"{num6}");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
6 -> да
7 -> да
1 -> нет
*/

int number = new Random().Next(1,8);
Console.WriteLine($"день недели = {number}");
if(number < 5)
{
    Console.WriteLine("Этот день будний");
}
else
{
    Console.WriteLine("Этот день выходной");
}