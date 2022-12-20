// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите размер массива ");

int inputNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[inputNumber];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(inputNumber + 1);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();