using System;

static class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 3, 2, 5, 6, 1, 7, 7, 5, 2 };

        try
        {
            Console.Write("ElementOfOrder2() should be returns: ");
            Console.WriteLine(numbers.ElementOfOrder2());
            Console.Write("ElementOfOrder(2) should be returns: ");
            Console.WriteLine(numbers.ElementOfOrder(2));
            Console.Write("ElementOfOrder(3) should be return: ");
            Console.WriteLine(numbers.ElementOfOrder(3));
            Console.WriteLine("ElementOfOrder(20) should be throw an exception: ");
            Console.WriteLine(numbers.ElementOfOrder(20));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    /// <summary>
    /// returns the 2nd largest number in the array.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    //private static int ElementOfOrder2(this int[] array)
    //{
    //    if (array.Length < 2)
    //    {
    //        throw new ArgumentException("Array must have at least two elements.");
    //    }

    //    int largest = int.MinValue;
    //    int secondLargest = int.MinValue;

    //    foreach (int n in array)
    //    {
    //        if (n > largest)
    //        {
    //            secondLargest = largest;
    //            largest = n;
    //        }
    //        else if (n > secondLargest && n != largest)
    //        {
    //            secondLargest = n;
    //        }
    //    }

    //    return secondLargest;
    //}

    public static int ElementOfOrder2(this int[] array)
    {
        return ElementOfOrder(array, 2);

    }

    public static T ElementOfOrder<T>(this T[] array, int orderLargest) where T : IComparable<T>
    {
        if (orderLargest > array.Length)
            throw new ArgumentException("orderLargest cannot be greater than the length of the array.");
        return array.OrderByDescending(n => n).ElementAt(orderLargest);
    }

}

