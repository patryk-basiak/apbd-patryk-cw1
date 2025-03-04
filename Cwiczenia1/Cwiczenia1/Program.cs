// See https://aka.ms/new-console-template for more information
static double GetAverage(int[] arr)
{
    int sum = 0;
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        sum += arr[i];
    }
    return (double) sum/length;

}

int[] arr = { 1, 3, 5, 3, 4, 7, 9, 4, 2, 7, 9 ,11};
Console.WriteLine(GetAverage(arr));