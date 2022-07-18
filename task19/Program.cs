//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 9999 || N < 100000){

int n = N;
int reverse = 0;
int r;
int count = 1;
while ( count <=5 )
{ 
  r = n % 10;
  reverse = reverse*10+r;
  n = n/10;
  count++;
} 
if (N == reverse)
{
  Console.WriteLine("Это палиндром");
}
else
{
  Console.WriteLine("Это не палиндром");
}

}
