using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ferrari
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var name = Console.ReadLine().Trim();

            ICar car = new Ferrari(name);

            Console.WriteLine($"{car.Model}/{car.UseBreaks}/{car.PushTheGas}/{car.DriverName}");


            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }

        }
    }
}
