// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int len = NumberLen(number);
SumNumbers(number, len);

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
        {
           a = a / 10;
           index++; 
        }
        return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    Console.WriteLine(sum);
}
