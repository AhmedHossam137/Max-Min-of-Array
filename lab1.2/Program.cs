using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[10];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Enter the number for index {i}:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = getMax(arr);
        int min = getMin(arr);

        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Minimum value: {min}");
    }

    static int getMax(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }

    static int getMin(int[] arr)
    {
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }
}
