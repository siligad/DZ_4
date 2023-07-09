/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void arr(int []array)
{
    int index;
    Console.Write("[");
    for (index = 0; index < array.Length ; index++)
    {
        Console.Write($"{array[index]} ");
    }
    Console.Write("]");
}

int i, size=8;
int[] array = new int[size];
for (i = 0;  i < size ; i++)
{
    array[i]=new Random().Next(10, 1001);
}
arr(array);