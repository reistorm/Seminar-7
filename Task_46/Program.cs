﻿// Задайте двумерный массив размером m x n
// заполненный случайными числами

int[,] GetArray(int a, int b) 
{
    int [,] array = new int[a,b];
    Random rnd = new Random();
    for (int i=0; i < array.GetLength(0); i++) // Обращение к первой размерности
    {
        for (int j = 0; i < array.GetLength(1); j++)
        {
            array [i,j] = rnd.Next(10);
        }
    }
    return array;

}

void PrintArray(int [,] array) 
{
    for (int i=0; i < array.GetLength(0); i++) // Обращение к первой размерности
    {
        for (int j = 0; i < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = GetArray(5, 7);
PrintArray(arrayResult);


