using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Net.M.A008.Exercise1
{
    static class Program
    {
        public static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            AddEmplementOfArray(array);
            CountInt(array);
            CountOf(array, typeof(int));
            CountOf<string>(array);
            MaxOf<int>(array);
        }
        public static void AddEmplementOfArray(ArrayList array)
        {
            array.Add("Hung");
            array.Add("Vu");
            array.Add(1);
            array.Add(2);
            array.Add("Van");
            array.Add(3.9d);
        }
        public static int CountInt(this ArrayList array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item is int)
                {
                    count++;
                }
            }
            Console.WriteLine($"CountInt() should be returns: {count}.");
            return count;
        }
        public static int CountOf(this ArrayList array, Type dataType)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item.GetType().Equals(dataType))
                {
                    count++;
                }
            }
            Console.WriteLine($"CountInt() should be returns: {count}.");
            return count;
        }
        public static void CountOf<T>(this ArrayList array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item.GetType().Equals(typeof(T)))
                {
                    count++;
                }
            }
            Console.WriteLine($"CountOf<string>() should be returns: {count}");
        }
        public static void MaxOf<T>(this ArrayList array)
        {
            List<int> list = new List<int>();
            var max = int.MinValue;
            foreach (var item in array)
            {
                if (item.GetType().Equals(typeof(T)))
                {
                    list.Add((int)item);
                }

            }

            foreach (var item1 in list)
            {
                if (item1 > max)
                {
                    max = item1;
                }
            }
            Console.WriteLine($"MaxOf<int>() should be returns: {max}");
        }
    }
}