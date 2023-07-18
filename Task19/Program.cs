// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number>9999 && number<100000)
{
  if (number%10 == number/10000 && (number/10)%10 == (number/1000)%10)
  Console.WriteLine("Это полиндром");
  else Console.WriteLine("Это обычное число");
}
else Console.WriteLine ("Вы ввели не пятизначное число");
