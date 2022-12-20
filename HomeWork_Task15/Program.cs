/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

Console.WriteLine("Введите цифру, обозначающую день недели: ");

int input = int.Parse(Console.ReadLine());

    if (input == 1 || input == 2 || input == 3 || input == 4 || input == 5)
    {
        Console.WriteLine("Нет");
     }
    else if (input == 6 || input == 7)
    {
        Console.WriteLine("Да");
    }
    else
        Console.WriteLine("Неизвестное число");
