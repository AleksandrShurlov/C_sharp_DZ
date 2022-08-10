// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

void PalindromeSearch(int number)
{
    Console.Write("Enter a five-digit number: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number.ToString()[0] == number.ToString()[4] && number.ToString()[1] == number.ToString()[3])
    {
        Console.WriteLine("Wow, the number is a palindrome");
    }
    else
    {
        Console.WriteLine("The number is not a palindrome");
    }
}

int n = 0;

PalindromeSearch(n);