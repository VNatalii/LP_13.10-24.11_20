


int Facorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact = i*fact;
    }
    return fact;
}

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

int factorial = Facorial(a);
Console.WriteLine($"Произведение чисел от 1 до {a} равно {factorial}");
