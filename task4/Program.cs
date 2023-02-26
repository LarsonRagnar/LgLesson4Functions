// Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] GetBinaryArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(9);
    }
    return array;
}
int[] resultArray = GetBinaryArray(8);
// for (int i = 0; i < resultArray.Length; i++)
// {                                               //вывод из массива с помощью for
//     Console.WriteLine(resultArray[i]+ "\t");
// }

Console.WriteLine($"Массив:  [{String.Join(";", resultArray)}]");   // вывод из массива с помощью интерполяции
