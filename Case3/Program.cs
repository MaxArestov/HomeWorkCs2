// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 1 & num > 7)
{
    Console.WriteLine("От единицы до семерки");
    return;
}
int check = CheckWeekday(num);
if(check == 1) Console.WriteLine("Выходной");
else Console.WriteLine("Рабочий день");



int CheckWeekday(int number)
{
    number = num;
    if (number == 6 || number == 7)
    {
        number = 1;
    }
    else
    {
        number = 0;
    }
    return number;
}
