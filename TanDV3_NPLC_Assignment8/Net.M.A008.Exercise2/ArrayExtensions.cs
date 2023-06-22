using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A008.Exercise2
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// RemoveDuplicate int
        /// </summary>
        /// <param name="array"></param>
        public static void RemoveDuplicate(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //Kiểm tra xem phần tử được chọn đã được in chưa
                int j;
                for (j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        break;
                    }
                }
                //  Nếu chưa được in ra thì in nó
                if (i == j)
                {
                    Console.Write($"{array[i]}" + " \"");
                }
            }
        }
        /// <summary>
        /// RemoveDuplicate string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void RemoveDuplicate<T>(this T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //Kiểm tra xem phần tử được chọn đã được in chưa
                int j;
                for (j = 0; j < i; j++)
                {
                    if (((T)array[i]).Equals((T)array[j]))
                    {
                        break;
                    }
                }
                //  Nếu chưa được in ra thì in nó
                if (i == j)
                {
                   Console.Write($"{array[i]}" + " \"");
                }
            }
        }
    }
}
