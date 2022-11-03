// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int b = Convert.ToInt32(Console.ReadLine());

int Degree (int a, int b)

{
    int deg = a;
    for ( int i = 1; i < b; i++)
    deg *= a;
        return deg;
}

Console.WriteLine($"Число {a} в степени {b} равняется {Degree (a,b)}");

