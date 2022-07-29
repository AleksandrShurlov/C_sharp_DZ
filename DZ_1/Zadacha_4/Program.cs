int a, b, c;

Console.Write("Enter number one: ");
a = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 - преобразует в int значение любого типа

Console.Write("Enter number two: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number three: ");
c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("Max = ");
Console.WriteLine(max);