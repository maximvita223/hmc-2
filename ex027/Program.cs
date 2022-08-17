// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ??"0");
int sum = 0;
if (num > 0)
{
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
}
else
{
    Console.WriteLine("Введите положительное число");
    return;
}
Console.WriteLine(sum);