int[,] x = new int[10,10];
for(int i=0;i<x.GetLength(0);i++)
    for(int j=0;j<x.GetLength(1);j++)
        x[i,j] = new Random().Next(1,100);

void Print(int[,] arr)
{
    for(int i=0;i<x.GetLength(0);i++)
    {
        for(int j=0;j<x.GetLength(1);j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
Print(x);