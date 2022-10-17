Random random=new Random();
int[] mas = new int[random.Next(10,20)];
int n=mas.Length;
for(int i=0;i<n;i++)
{
    mas[i] = random.Next(-100,100);
    Console.Write(mas[i]); Console.Write(" ");
}
int k = 0;
Console.WriteLine();
for (int i=1; i<n-1; i++)
{
    if ((mas[i] > mas[i+1])&&(mas[i] > mas[i-1]))
            k++;
}
if (mas[0] > mas[1])
    k++;
if (mas[n-1] > mas[n-2])
    k++;
Console.WriteLine(k);