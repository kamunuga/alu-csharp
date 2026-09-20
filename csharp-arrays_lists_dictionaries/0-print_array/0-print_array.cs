using System;

public class Array
{
    /// <summary>
    /// Creates a new array of integers, prints it, and returns it.
    /// </summary>
    /// <param name="size">The size of the array to create.</param>
    /// <returns>The newly created array, or null if size is negative.</returns>
    public static int?[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int?[] newArray = new int?[size];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
        }

        for (int i = 0; i < size; i++)
        {
            if (i > 0)
            {
                Console.Write(" ");
            }
            Console.Write(newArray[i]);
        }
        Console.WriteLine();

        return newArray;
    }
}
