//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1; 
Double r;
while (count <(N + 1))
{
    r = Math.Pow(count,3);
    Console.WriteLine($"{r}");
    count++;
}