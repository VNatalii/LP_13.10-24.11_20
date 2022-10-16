Console.Write("Введите число дня недели ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 8)
{
if (num == 1)
{
    Console.Write($"Число {num} это понедельник");
}
else {}

if (num == 2)
{
    Console.Write($"Число {num} это вторник");
}
else {}

if (num == 3)
{
    Console.Write($"Число {num} это среда");
}
else {}

if (num == 4)
{
    Console.Write($"Число {num} это четверг");
}
else {}

if (num == 5)
{
    Console.Write($"Число {num} это пятница");
}
else {}

if (num == 6)
{
    Console.Write($"Число {num} это суббота");
}
else {}

if (num == 7)
{
    Console.Write($"Число {num} это воскресенье");
}
else {}

}

else 
{
    Console.Write($"Число {num} не являеся днем недели");
}
