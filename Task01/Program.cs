Console.Write("Введите число a ");
int numa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb*numb == numa)
{
    Console.Write($"Число {numa} являеся вкадратом чила {numb}");
}
else 
{
    Console.Write($"Число {numa} не являеся вкадратом чила {numb}");
}

