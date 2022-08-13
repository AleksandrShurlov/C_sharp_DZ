// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

void Exponent(int a, int b)
{
    Console.Write($"A to the power of B is = {Math.Pow(a, b)}");
}

Console.Write("Enter number A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number B: ");
int b = Convert.ToInt32(Console.ReadLine());

Exponent(a, b);