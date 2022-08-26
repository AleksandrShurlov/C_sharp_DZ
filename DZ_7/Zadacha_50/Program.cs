// Напишите программу, которая на вход принимает позиции элемента
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

void SearchIndex(int[,] matr, int find)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == find)
            {
                Console.WriteLine($"The element exists and its index is {i}, {j}");
                count += 1;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine("There is no such number in the array.");
    }
}

void SearchElement(int[,] matr, int m, int n)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == m && j == n)
            {
                Console.WriteLine($"Such an element exists and is equal to {matr[i, j]}");
                count += 1;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine("No such element.");
    }
}

void SearchMethod()
{
    int[,] matrix = new int[4, 4];

    Console.WriteLine("1. Find element by its index");
    Console.WriteLine("2. Find element index");
    Console.Write("Enter 1 or 2 to choose: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine("Enter element index [i, j].");

        Console.Write("Enter i: ");
        int i = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter j: ");
        int j = Convert.ToInt32(Console.ReadLine());

        FillArray(matrix);
        PrintArray(matrix);
        SearchElement(matrix, i, j);
    }
    else if (choice == 2)
    {
        Console.Write("Enter the element you are looking for: ");
        int findElement = Convert.ToInt32(Console.ReadLine());

        FillArray(matrix);
        PrintArray(matrix);
        SearchIndex(matrix, findElement);
    }
    else
    {
        Console.WriteLine("Incorrect values entered.");
        return;
    } 
}

SearchMethod();