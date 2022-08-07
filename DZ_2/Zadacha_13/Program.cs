void Search3(int arg)
{   
    Console.Write("Enter the number: ");
    arg = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(arg > 99 ? arg.ToString()[2] : "No third digit");
}

//Нашёл в интернете такой способ поиска цифры на нужной позиции, он мне показался интересным. 
//Постарался вникнуть, как он работает, доработал его для данной задачи, и всё получилось.

int a = 0;

Search3(a);