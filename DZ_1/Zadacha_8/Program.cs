int a;
int b = 0;

Console.Write("Enter a positive integer number: ");
a = Convert.ToInt32(Console.ReadLine());

while(b < a - 1)
{   
    b = b + 2;
    Console.WriteLine(b);
}
Console.Write("Even numbers from 1 to ");
Console.Write(a);