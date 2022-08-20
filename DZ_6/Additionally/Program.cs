//Напишите программу, на вход которой подаётся размерность матрицы
// и потом прямоугольная матрица в виде последовательности строк.

// Программа должна вывести матрицу того же размера,
// у которой каждый элемент в позиции i, j равен сумме элементов
// первой матрицы на позициях (i-1, j), (i+1, j), (i, j-1), (i, j+1).
// У крайних символов соседний элемент находится с противоположной стороны матрицы.


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // вместо i < matrix.GetLength(0); можно написать i < 3; т.к. размерность [3, 4]
    {
        for (int j = 0; j < matr.GetLength(1); j++) // вместо j < 4 matrix.GetLength(1); можно написать j < 4; т.к. размерность [3, 4]
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

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

void NewMatrix(int[,] matr, int[,] newMatr)
{
    int size = newMatr.GetLength(0) - 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (size == 0)
            {
                newMatr[i, j] = matr[i, j] * 4;
            }
            else if (i == 0 && j == 0)
            {
                newMatr[i, j] = matr[i + 1, j] + matr[i, j + 1] + matr[size, 0] + matr[i, size];
            }
            else if (i == 0 && j == matr.GetLength(1) - 1)
            {
                newMatr[i, j] = matr[i, j - 1] + matr[i + 1, j] + matr[i, j - size] + matr[i + size, j];
            }
            else if (i == matr.GetLength(0) - 1 && j == 0)
            {
                newMatr[i, j] = matr[i - 1, j] + matr[i, j + 1] + matr[i, j + size] + matr[i - size, j];
            }
            else if (i == matr.GetLength(0) - 1 && j == matr.GetLength(1) - 1)
            {
                newMatr[i, j] = matr[i - 1, j] + matr[i, j - 1] + matr[i - size, j] + matr[i, j - size];
            }
            else if (i > 0 && i < size && j == 0)
            {
                newMatr[i, j] = matr[i - 1, j] + matr[i, j + 1] + matr[i + 1, j] + matr[i, j + size];
            }
            else if (i > 0 && i < size && j == matr.GetLength(1) - 1)
            {
                newMatr[i, j] = matr[i - 1, j] + matr[i, j - 1] + matr[i + 1, j] + matr[i, j - size];
            }
            else if (i == 0 && j > 0 && j < size)
            {
                newMatr[i, j] = matr[i, j - 1] + matr[i + 1, j] + matr[i, j + 1] + matr[i + size, j];
            }
            else if (i == matr.GetLength(0) - 1 && j > 0 && j < size)
            {
                newMatr[i, j] = matr[i, j - 1] + matr[i - 1, j] + matr[i, j + 1] + matr[i - size, j];
            }
            else if (i > 0 && i < size && j > 0 && j < size)
            {
                newMatr[i, j] = matr[i - 1, j] + matr[i + 1, j] + matr[i, j - 1] + matr[i, j + 1];
            }
        }
    }
}

Console.Write("Enter matrix dimension: ");
int dimension = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[dimension, dimension];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

int[,] newMatrix = new int[dimension, dimension]; ;
NewMatrix(matrix, newMatrix);
PrintArray(newMatrix);