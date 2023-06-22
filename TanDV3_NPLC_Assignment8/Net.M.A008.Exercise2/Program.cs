using System;
using System.Collections.Generic;

namespace Net.M.A008.Exercise2
{
    public class Program 
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 3, 5, 6, 5, 2 };
            string[] array2 = new string[] { "Hung", "Vu", "Van", "Hung", "Quang", "Huy", "Vu" };
            Console.WriteLine("Int array after distict: ");
            ArrayExtensions.RemoveDuplicate(array);
            Console.WriteLine("");
            Console.WriteLine("String array after distict: ");
            ArrayExtensions.RemoveDuplicate<string>(array2);
        }
    }
}



