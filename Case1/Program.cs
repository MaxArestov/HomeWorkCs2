// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите любое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Ошибка. Введите ТРЕХЗНАЧНОЕ число");
    return;
}
int secondValue = GetSecondValue(number);

Console.WriteLine($"Вторая цифра - {secondValue}");


int GetSecondValue(int number1)
{
     number1 = number / 10;
    int second = number1 % 10;
    return second;
}