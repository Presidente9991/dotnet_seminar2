/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число (максимум 100000): ");

int number = int.Parse(Console.ReadLine()!);
int third;

Console.Write($"{number} -> ");

if(number < 100) 
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else if (number > 99999)
{
    Console.WriteLine("Укажите меньшее число!");
}
else 
{
    while (number >= 1000) 
    {
        number /= 10;
    }
    third = number % 10;
    Console.Write(third);
}