int[] A = new int[100];
int sum = 0;
Random rnd = new Random();
for (int i = 0; i < A.Length; i++)
{
    A[i] = rnd.Next(-1000,1000);
}
Console.WriteLine("Чётные: ");
for (int i = 0; i < A.Length; i++)
{
    if (A[i]%2 == 0)
    {
        Console.Write(A[i] + ", ");
    }
}
Console.WriteLine();
Console.WriteLine("Кратные 3: ");
for (int i = 0; i < A.Length; i++)
{
    if(A[i]%3 == 1)
    {
        Console.Write(A[i] + ", ");
    }
}
Console.WriteLine();
for (int i = 0; i < A.Length; i++)
{
    if (A[i] < 0)
    {
        sum += A[i];
    }
}
Console.WriteLine("Сумма отрицательных чисел: " + sum);