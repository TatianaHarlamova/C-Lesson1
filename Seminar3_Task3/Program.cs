﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число N - ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
for(int i = 1; i<= N; i++)
    array[i-1] = i*i*i;
for(int i = 0; i<N; i++)    
   Console.Write($"{array[i]}, "); 