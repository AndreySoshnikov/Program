//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
//недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

System.Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 6)
{
    System.Console.WriteLine("Нет, этот день не является выходным");
}
else if (day == 6 || day == 7)
{
    System.Console.WriteLine("Да, этот день выходной");
}
else
{
    System.Console.WriteLine("Такого дня не существует");
}