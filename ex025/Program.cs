// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.Clear();

// Console.WriteLine("Введите число   ");
// double a = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите степень   ");
// double b = int.Parse(Console.ReadLine() ?? "0");


// Console.Write(Math.Pow(a, b));



Console.Write("Введите число  ");
int num = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите степень  ");
int n = int.Parse(Console.ReadLine()?? "0");

int num_n = 1;
for (int i = 0; i < n; i++)
{
    num_n *= num;
}
Console.WriteLine($"{num} ^ {n} = {num_n}");
