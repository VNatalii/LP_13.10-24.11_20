// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x y)

Console.WriteLine("Введите число четверти ");
int num = Convert.ToInt32(Console.ReadLine());

//  if (num > 0 && num < 5)
// {
//     if (num == 1) Console.Write($"x > 0 и y > 0");
//     else if (num == 2) Console.Write($"x < 0 и y > 0");
//     else if (num == 3) Console.Write($"x < 0 и y < 0");
//     else Console.Write($"x < 0 и y < 0");
// }

// else
// {
//     Console.Write($"Не верное число");
// }

string Quarter (int numx)
{
    if (numx == 1) return "x > 0 и y > 0";
    if (numx == 2) return "x < 0 и y > 0";
    if (numx == 3) return "x < 0 и y < 0";
    if (numx == 4) return "x < 0 и y < 0";
    return "Не верное число";
}

string quarter = Quarter (num);
Console.WriteLine($"{quarter}");

