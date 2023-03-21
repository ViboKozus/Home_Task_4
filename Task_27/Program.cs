#pragma warning disable
Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

Console.WriteLine ("Введите число A");
int A;
int.TryParse(Console.ReadLine ()!, out A);
void sum ()
{
int sum = 0;
int b = A;
while ( A > 0)
    {
    int ost = A % 10;
    A = A / 10;
    sum = sum + ost;
    }
Console.WriteLine($"{b} -> {sum}" );
}

sum ();