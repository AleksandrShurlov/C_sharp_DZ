void SearchWeekend(int[] number)
{
    int size = number.Length;
    int index = 0;
    int sat = 6;
    int sun = 7;
    while (index < size)
    {
        if(number[index] == sat || number[index] == sun)
        {
            Console.WriteLine($"{number[index]}: Wow, weekend");
        }
        else
        {
            Console.WriteLine($"{number[index]}: The Weekday"); 
        }
        index++;
    }
}

void FillArray(int[] number)
{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        number[index] = new Random().Next(1, 8);
        index++;
    }
}

int[] days = new int[1];

FillArray(days);
SearchWeekend(days);