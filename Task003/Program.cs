Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int count = (-num);

while (count > (-num-1) && count < (num+1))
{
    Console.Write($"{count} ");
    count++;
}
