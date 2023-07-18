// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void PowNumbers(int number)
{
    for (int i = 1; i <= number; i++)
    Console.Write(Math.Pow(i, 3) + " ");

}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
PowNumbers(number);