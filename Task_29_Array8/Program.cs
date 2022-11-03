// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов с клавиатуры и выводит массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33

int [] arr = new int[8];

for (int i = 0; i < 8; i++)
{
  Console.Write ($"Введите элемент массива с индексом {i} ");
  arr [i] = int.Parse(Console.ReadLine());
}  

void PrintArray (int []collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write ($"{collection[position]} ");
        position++;
    }
}
Console.WriteLine ();
Console.Write ("Массив: [");
PrintArray (arr);
Console.WriteLine ("]");



