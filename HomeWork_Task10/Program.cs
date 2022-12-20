/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите число:");

string numberStr = Console.ReadLine() ?? "";
int number = int.Parse(numberStr);
if (number >=100 && number < 1000)
{
    int firstDigit = number % 100;
    int result = firstDigit / 10;
    Console.WriteLine(result);
}
else
Console.WriteLine("Число не соответствует заданным параметрам");
