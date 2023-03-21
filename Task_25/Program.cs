#pragma warning disable
Console.Clear();
Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

Console.WriteLine ("Введите число A");
int A;
int.TryParse(Console.ReadLine ()!, out A);
Console.WriteLine("Введите число B");
int B;
int.TryParse(Console.ReadLine ()!, out B);
int N = 1;
for (int i = 0; i < B; i++)
{
    N = N * A;
}

Console.WriteLine($"{A} в степени {B} равно -> {N}");