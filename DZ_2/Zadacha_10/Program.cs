void FillArray(int[] number1, int[] number2, int[] number3)
{
    int length1 = number1.Length;
    int index1 = 0;
    while (index1 < length1)
    {
        number1[index1] = new Random().Next(1, 9);
        index1++;
    }

    int length2 = number2.Length;
    int index2 = 0;
    while (index2 < length2)
    {
        number2[index2] = new Random().Next(0, 9);
        index2++;
    }

    int length3 = number3.Length;
    int index3 = 0;
    while (index3 < length3)
    {
        number3[index3] = new Random().Next(0, 9);
        index3++;
    }
}

void PrintArray(int[] number1, int[] number2, int[] number3)
{
    int length1 = number1.Length;
    int index1 = 0;
    while (index1 < length1)
    {
        Console.Write(number1[index1]);
        index1++;
    }

    int length2 = number2.Length;
    int index2 = 0;
    while (index2 < length2)
    {
        Console.Write(number2[index2]);
        index2++;
    }

    int length3 = number3.Length;
    int index3 = 0;
    while (index3 < length3)
    {
        Console.Write(number3[index3]);
        index3++;
    }
}

int[] array1 = new int[1];
int[] array2 = new int[1];
int[] array3 = new int[1];

FillArray(array1, array2, array3);
PrintArray(array1, array2, array3);

Console.WriteLine();
Console.WriteLine($"The second digit of this number: {array2[0]}");