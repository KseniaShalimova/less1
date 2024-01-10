int[] arr = { 5, 3, 22, 44, 35, 49, 66, 68, 1, 57 };
int i = 0;
while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}