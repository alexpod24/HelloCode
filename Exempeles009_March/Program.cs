Console.Clear();

int[] arrey = { 13, 24, 36, 14, 54, 16, 37, 38, 14 };

int n = arrey.Length;
int find = 14;
int index = 0;
while (index < n)
{
    if (arrey[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }

        index++;
}