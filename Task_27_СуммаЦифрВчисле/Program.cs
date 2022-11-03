// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (x > 0)
// {
// int i = x % 10;
// x = x / 10;
// sum = sum + i;
// }
// Console.WriteLine("Сумма всех цифр числа: " + sum);

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int SumNumber (int x)
{
int sum = 0;
int y = sum;
while (x > 0)
{
int i = x % 10;
x = x / 10;
y = y + i;
}
return y;
}
int sumNumber = SumNumber(x);
Console.WriteLine("Сумма всех цифр числа: " + sumNumber);
