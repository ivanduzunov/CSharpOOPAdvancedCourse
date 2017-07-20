using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var smartphone = new Smartphone("Smartphone");
            Test(smartphone);
        }

        public static void Test(ISmartphone smartphone)
        {
            var numbers = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            var urls = Console.ReadLine().Split();

            foreach (var url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }
}
