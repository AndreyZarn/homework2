// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
void Rand (int[] array)
{
   for (int i = 0; i<array.Length; i++)
   {
   array[i] = new Random().Next(-1000,1000);
   }
}

void Sum1 (int[] array)
{
    for (int j = 1; j < array.Length;)
    {
        sum = sum + array[j];
        j=j+2;
    }


}

void Print (int[]array)
{
for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    
    }
}   


Rand(array);
Print(array);
Sum1(array);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных позиций массива = {sum}");