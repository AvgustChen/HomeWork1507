/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int NewNumber(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.Write("Введите число А: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b=Convert.ToInt32(Console.ReadLine());

int result=NewNumber(a, b);

Console.Write($"Число {a} в степени {b} = {result}");*/




/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumOfNumber(int num)
{
    int summa = 0;
    while (num > 0)
    {
        summa += num % 10;
        num /= 10;
    }
    return summa;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int summa = SumOfNumber(number);

Console.WriteLine($"Сумма цифр в числе {number} = {summa}");

*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int[] CreatArray(int size, int minValue, int MaxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, MaxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0;i<array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
Console.Write("Введите размер желаемого массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите минимальное число диапазона цифр в массиве: ");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите максимальное число диапазона цифр в массиве: ");
int maxValue=Convert.ToInt32(Console.ReadLine());

int[] binaryArray = CreatArray(size, minValue, maxValue);
ShowArray(binaryArray);

