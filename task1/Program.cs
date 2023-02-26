// void: нет оператора return   называют процедурой
// тип_возвращаемого_значения имя (Параметры)

int Calculate(int a, int b, char sign)
{
    int result = 0;
    if (sign == '*')
    {
        result = a * b;
    }
    else if (sign == '+')
    {
        result = a + b;
    }
    else if (sign == '-')
    {
        result = a - b;
    }
    else
    {
        Console.WriteLine("такого знака нет");
    }
    return result;                               // ПРИМЕР ВЫЗОВА МЕТОДА
} 
Console.WriteLine(Calculate(3,5,'*'));
