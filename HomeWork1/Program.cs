// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Numbers(int number)
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

Numbers(number);
