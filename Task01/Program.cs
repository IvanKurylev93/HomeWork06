//Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
int x=0;
Console.WriteLine("Введите колличество цифр: ");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 1: ");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
x = Convert.ToInt32(Console.ReadLine());
{
    if (x >= 0)
        Console.WriteLine("Положительных чисел: " + x);
        Console.ReadLine();
    }



