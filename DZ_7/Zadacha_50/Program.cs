﻿// Напишите программу, которая на вход принимает позиции элемента
// либо значение элемента в двумерном массиве,
// и возвращает значение либо индекс этого элемента или же указание,
// что такого элемента нет.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];

FillArray(matrix);
PrintArray(matrix);
