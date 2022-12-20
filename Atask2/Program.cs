// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А ");
int enterNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В ");
int enterNumberB = Convert.ToInt32(Console.ReadLine());

int result = enterNumberA;
for (int i = 2; i <= enterNumberB; i++)
{
    result = result * enterNumberA;
}
Console.WriteLine($"{enterNumberA}||{enterNumberB} = {result}");
