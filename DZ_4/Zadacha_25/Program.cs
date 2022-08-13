// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

/*void Exponent(int a, int b) // Первый способ
{
    Console.Write("Enter number A: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number B: ");
    b = Convert.ToInt32(Console.ReadLine());
    
    Console.Write($"A to the power of B is = {Math.Pow(a, b)}");
}*/


void Exponent(int a, int b) // Второй способ (цикл)
{
    Console.Write("Enter number A: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number B: ");
    b = Convert.ToInt32(Console.ReadLine());

    int result = 1;

    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    Console.Write($"A to the power of B is = {result}");
}

int a = 0, b = 0;

Exponent(a, b);