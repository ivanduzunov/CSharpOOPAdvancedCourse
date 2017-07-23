using _01.Generic_Box_of_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CountDouble();
        }

        public static int Count<T>(List<Box<T>> boxes, T comparableElement)
            where T : IComparable<T>
        {
            var count = boxes.Count(b => b.value.CompareTo(comparableElement) > 0);
            return count;
        }

        public static void CountStrings()
        {
            List<Box<string>> boxes = new List<Box<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }
            var compElement = Console.ReadLine();
            Console.WriteLine(Count(boxes, compElement));
        }
        public static void CountDouble()
        {
            List<Box<double>> boxes = new List<Box<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }
            var compElement = double.Parse(Console.ReadLine());
            Console.WriteLine(Count(boxes, compElement));
        }
    }
}
