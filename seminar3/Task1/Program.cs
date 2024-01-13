int[] arr = new int[] {14,5,34,76,43};
int target = 14;
bool flag = false;
foreach (int e in arr)
{
    if (e==target)
    {
        Console.WriteLine("Yes");
        flag = true;
    }
}

if (flag == false)
{
    Console.WriteLine("No");
}