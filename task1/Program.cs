/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Random rnd = new Random();
int number = rnd.Next (100, 1000);
Console.WriteLine(number);
int firstN = number % 10;
int secondN = (number / 10) % 10;
Console.WriteLine(secondN);

