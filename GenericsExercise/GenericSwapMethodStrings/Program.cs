using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            
        }

        public static void Swap<T>(IList<T> list, int index1, int index2)
        {
            T element1 = list[index1];
            T element2 = list[index2];
            list[index1] = element2;
            list[index2] = element1;
        }

        public static void SwapStrings()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            var indexes = Console.ReadLine().Split();
            Swap(list, int.Parse(indexes[0]), int.Parse(indexes[1]));
            foreach (var value in list)
            {
                Console.WriteLine($"{value.GetType().FullName}: {value}");
            }
        }
        public static void SwapIntegers()
        {
            int n = int.Parse(Console.ReadLine());
            IList<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            var indexes = Console.ReadLine().Split();
            Swap(list, int.Parse(indexes[0]), int.Parse(indexes[1]));
            foreach (var value in list)
            {
                Console.WriteLine($"{value.GetType().FullName}: {value}");
            }
        }
    }
}
