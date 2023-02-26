// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// 1 без метода
// Console.WriteLine("Введите число ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i < A; i++)
// {
//     sum = sum + i;  // sum += i  сокращенный оператор присваивания
// }
// Console.WriteLine($"сумма чисел от 1 до {A} = {sum}");


// 2 с методом Хардкор


Console.WriteLine("Введите число ");
int limit = Convert.ToInt32(Console.ReadLine());
int Getsum(int A)
{
    int sum = 0;
    for (int i = 0; i <= A; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine($"сумма чисел от 1 до {limit} = {Getsum(limit)}");
Console.WriteLine($"сумма чисел от 1 до {45} = {Getsum(45)}");
Console.WriteLine($"сумма чисел от 1 до {95} = {Getsum(95)}");
Console.WriteLine($"сумма чисел от 1 до {456} = {Getsum(456)}");

