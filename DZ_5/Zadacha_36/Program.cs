// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SumElementsOddPosition(int[] array)
{   
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"The sum of the elements in odd positions is {sum}");
}

int[] a = new int[6];

FillArray(a);
PrintArray(a);
SumElementsOddPosition(a);