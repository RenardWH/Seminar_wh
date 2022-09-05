/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


// решение 1

/*Console.WriteLine("Введите  число: ");
int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int rang =0;
    int devide = 10;
        while (numberA/devide>0)
        {
            rang++;
            devide = devide * 10;
        }
 
    if (rang < 2&rang>-2)
    {
        Console.WriteLine(("Третьей цифры нет"));
    } 
    else
    {
        devide = 1;
        for (int i =0; i<rang-2; i++)
        {
            devide = devide *10;
        }

        
        Console.WriteLine((numberA/devide%10));
    }
*/

//решение 2

Console.WriteLine("Введите  число: ");
int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int rang =0;
    int devide = 10;
        while (numberA/devide>0)
        {
            rang++;
            devide = devide * 10;
        }
 
    if (rang < 2&rang>-2)
    {
        Console.WriteLine(("Третьей цифры нет"));
    } 
    else
    {
        devide = devide/10;

        int [] array = new int [rang+1];
        for (int i = 0; i <=rang; i++)
        {
            array[i] = numberA%(devide*10)/devide;
            devide=devide / 10;

        }


       Console.WriteLine(array[2]);
    }
