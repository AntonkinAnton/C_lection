int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array1 = {91,28,63,44,55,16,27,81,49};


int max= Max (
    Max (array1[0], array1[1], array1[2]),
    Max (array1[3], array1[4], array1[5]),
    Max (array1[6], array1[7], array1[8])
   );
Console.WriteLine(max);