// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*void Numbers(int number)
{
    while (number > 99999 || number <= 9999)
    {
        Console.WriteLine("Вы ввели неверное число. Попробуйте снова.");
        Console.Write("Введите пятизначное число, и мы проверим является ли оно палиндромом: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    int num1 = number % 10;
    int num2 = number / 10 % 10;
    int num4 = number / 1000 % 10;
    int num5 = number / 10000 % 10;
    if (num1 == num5)
    {
        if (num2 == num4)
        {
            Console.WriteLine("Число является полиндромом");
        }
        else Console.WriteLine("Число НЕявляется полиндромом!");
    }
    else Console.WriteLine("Число НЕявляется полиндромом!");

}

Console.Write("Введите пятизначное число, и мы проверим является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());

Numbers(number);*/

// Задача 19 - 2. Напишите программу, которая принимает на вход ЛЮБОЕ число и проверяет, является ли оно палиндромом.
int[] NumbersToArray(int number) // преобразуем в массив
{
    string str = number.ToString();
    int[] num = new int[str.Length];
    for (int i = 0; i < str.Length; i++) // Заполняем массив числами
    {
        num[i] = str[i];
    }
    return num;
}
void Check(int[] array)
{
    int length = array.Length;
    int index = 0;
    int result = 0;
    while (index < length)
    {
        if (array[index] != array[length - 1])
        {
            result = -1;
            break;
        }
        result = 0;
        index++;
        length--;
    }
    if (result == 0) Console.Write("Число полиндром");
    if (result == -1) Console.Write("Число НЕполиндром");
}

Console.Write("Введите число, и мы проверим является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = NumbersToArray(number);
Check(array);
