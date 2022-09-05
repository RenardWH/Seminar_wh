/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите  число от 1 до 7 которое обозначет день недели, где 1 понедельник, 7 воскресенье ");
int numberA = Convert.ToInt32(Console.ReadLine());
while (numberA <1|numberA >7)
{
   
    Console.WriteLine("Введите  число от 1 до 7 которое обозначет день недели, где 1 понедельник, 7 воскресенье ");
     numberA = Convert.ToInt32(Console.ReadLine());

}
    if (numberA >5)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий");
    }