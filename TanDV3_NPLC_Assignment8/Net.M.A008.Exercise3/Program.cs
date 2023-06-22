using System.Runtime.CompilerServices;

namespace Net.M.A008.Exercise3
{
    static class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 7, 3, 2 };
            string[] array2 = { "Nguyen", "Van", "A", "Vu", "Van", "Hung" };
            Console.WriteLine($"Array Int: ");
            LastIndexOf(array, 3);
            Console.WriteLine($"Array String: ");
            LastIndexOf(array2, "Van");
        }
        /// <summary>
        /// LastIndexOf input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="elementValue"></param>
        public static void LastIndexOf<T>(this T[] array, T elementValue)
        {
            for (int i = array.Length-2; i >= 0 ; i--)
            {
                if (array[i].GetType().Equals(elementValue.GetType()))
                {
                    Console.WriteLine($"Last Index of '{elementValue}': {i}");
                    break;
                }
            }
        }
    }
}