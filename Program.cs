int[,] x = new int[10,10];
for(int i=0;i<x.GetLength(0);i++)
    for(int j=0;j<x.GetLength(1);j++)
        x[i,j] = new Random().Next(1,100);

void Print(int[,] arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] getSmallerArray(int[,] y)
{
    int[,] rs = new int[y.GetLength(0)-1,y.GetLength(1)-1];
    int min = Int32.MaxValue;
    int min_i = 0;
    int min_j = 0;
    for(int i=0;i<y.GetLength(0);i++)
        for(int j=0;j<y.GetLength(1);j++)
            if (y[i,j] < min)
            {
                min = y[i,j];
                min_i = i;
                min_j = j;
            }
    for(int i=0;i<y.GetLength(0);i++)
        for(int j=0;j<y.GetLength(1);j++)
            if(i<min_i && j < min_j) rs[i,j] = y[i,j];
            else if(i<min_i && j>min_j) rs[i,j-1] = y[i,j];
            else if(i>min_i && j<min_j) rs[i-1,j] = y[i,j];
            else if(i>min_i && j>min_j) rs[i-1,j-1] = y[i,j];
    return rs;
}

Print(x);
int[,] k = getSmallerArray(x);
Print(k);
Console.WriteLine("!");
