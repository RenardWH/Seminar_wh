﻿// See https://aka.ms/new-console-template for more information

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Введите трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((numberA/10%10));
