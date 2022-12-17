void FillArray(int[] collection)
{
    int len = collection.Length;
    int index = 0;
    while (index < len)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection,int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find) 
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int CountArray(int[] collection, int numb)
{
    int count = collection.Length;
    int index = 0;
    int same = 0;

    while (index < count)
    {
        if (collection[index] == numb)
        {
            same++;
        }
        
        index ++;
    }
return same;
}
int[] array = new int[new Random().Next(4,50)];

Console.WriteLine("Введите цифру для поиска:");
int numb = int.Parse(Console.ReadLine());
Console.WriteLine();
FillArray(array);
int count1 = CountArray(array, numb);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, numb);
Console.WriteLine("First Index = " + pos + ", Value = " + array[pos] + ", CountOfTheSamePositions = " + count1);