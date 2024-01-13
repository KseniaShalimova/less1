int[] arr = { -3, 4, 5, -6, 10, 8, -7, 0, 2, 1};
for (int i = 0; i<arr.Length; i++)
{
    arr[i] *= -1;
    Console.Write($"{arr[i]}, ");
}