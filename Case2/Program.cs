// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите любое число, больше 99: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет.");
    return;
}
int thirdValue = FindThirdValue(num);
Console.WriteLine($"Третья цифра в числе - {thirdValue}");


int FindThirdValue(int number)
{
    int third = number;
    while((number / 100) > 0)
    {
        third = number % 10;
        number = number / 10;
    }
    return third;
}