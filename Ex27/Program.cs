/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

void sum(int a)
{
    int result = 0;
    for (int temp = 0; a > 0; result += temp)
    {
        temp = a % 10;
        a = a / 10;
    }
    Console.WriteLine(result);
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
sum(n);
