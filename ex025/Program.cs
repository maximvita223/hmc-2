// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
 
Console.WriteLine("Введите число которое хотите возвести в степень");
double a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень в которую хотите возвести число");
double b = int.Parse(Console.ReadLine() ?? "0");

Console.Write(Math.Pow(a, b));