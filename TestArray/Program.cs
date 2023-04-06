namespace TestArray;

public class Program
{
    public static void Main()
    {
        var min = GetMin(new int[] { -5000, -5, 15 });
        Console.WriteLine(min);
        Console.ReadKey();
    }

    public static int? GetMin(int[] arr)
    {
        if (arr is null || arr.Length == 0) { return null; }
        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        return min;
    }
}