// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

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

void ArithmeticMeanColumn(int[,] matr)
{
    double sum1 = 0; double sum2 = 0; double sum3 = 0; double sum4 = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0)
            {
                sum1 = sum1 + matr[i, j];
            }
            else if (j == 1)
            {
                sum2 = sum2 + matr[i, j];
            }
            else if (j == 2)
            {
                sum3 = sum3 + matr[i, j];
            }
            else if (j == 3)
            {
                sum4 = sum4 + matr[i, j];
            }
        }
    }
    double average1 = Math.Round(sum1 / matr.GetLength(0), 1);
    double average2 = Math.Round(sum2 / matr.GetLength(0), 1);
    double average3 = Math.Round(sum3 / matr.GetLength(0), 1);
    double average4 = Math.Round(sum4 / matr.GetLength(0), 1);
    Console.Write($"Arithmetic mean of each column: {average1}; {average2}; {average3}; {average4}.");
}

int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);
ArithmeticMeanColumn(matrix);
