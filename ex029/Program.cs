// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// Console.WriteLine("Введите длину массива");
// int size = Convert.ToInt32(Console.ReadLine());  Ввод длины массива пользователем
// int[] array1 = new int[size];
int[] array1 = new int[8];
Random rnd = new Random();
Console.Write("Случайный массив из 8 элементов - ");
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = rnd.Next();
    Console.Write(array1[i] + " ");
}
