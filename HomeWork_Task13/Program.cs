/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число больше 0: ");

int number = int.Parse(Console.ReadLine());
string str = number.ToString();

if(number < 100 || number < 0 )
{
    Console.WriteLine("Вы ввели отрицательное число или в заданном числе третьей цифры нет!");
    
}
else
Console.WriteLine($"Третья цифра числа {number} - цифра {str[2]}");

