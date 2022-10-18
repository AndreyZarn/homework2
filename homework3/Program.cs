// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int min = array[0];
int max = array[0];
int razn = 0;
void Rand (int[] array)
{
   for (int i=0; i < array.Length; i++)
   {
   array[i] = new Random().Next(0,101);
   }
}
void NumMax (int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }


}

void NumMin (int[] array)
{   min = array[0];
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
           min = array[i];
        }
    }
}

void Print (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    
    }
}   

Rand(array);
Print(array);
NumMin(array);
NumMax(array);
razn = max-min;
Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {razn}");