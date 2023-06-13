/* 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
(использовать И и ИЛИ)
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите цифру (от 1 до 7): ");
int number = int.Parse(Console.ReadLine()!);

if(number >= 6 && number < 8) 
{
    Console.WriteLine($"{number} -> да, этот день выходной");
}
else if (number >= 1 && number < 7) 
{
    Console.WriteLine($"{number} -> нет, это будний день");
}
else Console.WriteLine("Указана некорректная цифра!");