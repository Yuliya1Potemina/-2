/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру, обозначающую день недели");
string daynumber = Console.ReadLine();

if (daynumber == "6" || daynumber == "7") 
{
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (daynumber.Length < 1 || daynumber.Length > 7)
  {
    Console.WriteLine("это вообще не день недели");
  }
  
  else 
  {
    Console.WriteLine("(этот день не выходной) -> нет");
  }
 
  

