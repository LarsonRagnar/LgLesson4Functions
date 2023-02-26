// Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (A>0)
{
    A = A/10;
    count++;
}
Console.WriteLine($"{count}");


Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int GetCountNumber( int number)
{
    int count = 0;
    while (number>0)
    {
        count++;
        number /= 10;
    }
    return count;
}
Console.WriteLine($"количество цифр {GetCountNumber(num)}");