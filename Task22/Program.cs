
void Table(int n)
{
    if (n>0)
    {
        int index = 1;
        while (index <= n)
        {
            Console.WriteLine($"{index} {index*index}");
            index++;
        }
    }
    else Console.WriteLine("Некорректное число");
}

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

Table(num);


