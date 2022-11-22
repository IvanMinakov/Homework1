Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int K = 1;
while (K <= N)
{
    if (K % 2 == 0)
    {
        Console.Write(K + " ,");
    }
    K +=1; 
}
