
int[] NewArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();

    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}

void SumArray(int[] array, int len)
{
    int sum1 = 0;
    int sum2 = 0;

    for (int i = 0; i < len; i++)
    {
        if (array[i] >= 0) sum1 = sum1 + array[i];
        else sum2 = sum2 + array[i];
    }
    
    Console.WriteLine($"сумма положительных чисел равна {sum1}");
    Console.WriteLine($"сумма отрицательных чисел равна {sum2}");

}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length > 0)
{
    int[] newarray = NewArray(length);
    PrintArray(newarray);
    Console.WriteLine("");
    SumArray (newarray, length);
    
}
else Console.WriteLine("Введено не верное число элементов массива");

