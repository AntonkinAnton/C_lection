int[] array = { 12, 52, 93, 4, 25, 76, 4, 68 };


int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{

    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}