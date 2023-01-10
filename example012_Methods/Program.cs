// string text = "Сегодня мы углубимся в тему и выделим 4 основных группы методов, "
// + "а также будем использовать их на практике. И познакомимся "
//  + "с новыми языковыми конструкциями, в частности, циклом.";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result += $"{newValue}";
//         else result += $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '/');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);


// сортировка массива

int[] arr = { 1, 5, 3, 6, 2, 8, 7, 5, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);
