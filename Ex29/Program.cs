/*Задача 29: Напишите программу, которая задаёт
массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void Fill(int[] arr) 
{
    int i = 0;
    Console.Write("[");
    for (int length = arr.Length; i < length; i++)
    {
        arr[i] = new Random().Next(0, 100);
        Console.Write($" {arr[i]}");
    }
    Console.Write(" ]");
}

int[] massiv = new int[8];
Fill(massiv);