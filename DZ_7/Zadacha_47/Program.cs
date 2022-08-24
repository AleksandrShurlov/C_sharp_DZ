// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void FillArray(double[,] matr)
{
    int multiplier = 10;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble() * multiplier;
        }
    }


    for (int i = 0; i < matr.GetLength(0); i = i + 2)
    {
        for (int j = 1; j < matr.GetLength(1); j = j + 3)
        {
            matr[i, j] = new Random().NextDouble() * multiplier * -1;
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matr[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the size of the array MxN.");

Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] realMatrix = new double[m, n];

Console.WriteLine();
FillArray(realMatrix);
PrintArray(realMatrix);