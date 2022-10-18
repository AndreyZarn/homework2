// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;

void Rand (int[] array)
{
   for (int i = 0; i<array.Length; i++)
   {
   array[i] = new Random().Next(100,1000);
   }
}
void Print (int[]array)
{
for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
        if (array[i]%2==0)
        {
            count++;
        }
    }
}   

Rand(array);
Print(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {count}");