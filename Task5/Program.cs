Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;
if (number1 > 99)
{
    k = number1;
    while (k >= 1000)
    {
        k /= 10;
        d = k % 10;
    }
    Console.WriteLine($"Третье число слева {d} ");
}
else
{
    Console.WriteLine($"Нет третьего числа");
}