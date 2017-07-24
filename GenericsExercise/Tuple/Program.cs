using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " "}, StringSplitOptions.RemoveEmptyEntries);
            var nameTokens = input.Take(input.Length - 1).ToList();
            var name = string.Join(" ", nameTokens);
            var adress = input[input.Length - 1];
            var tuple = new Tuple<string, string>(name, adress);
            Console.WriteLine(tuple);

            input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var nameBeer = input.Take(input.Length - 1).ToList();
            var beerTuple = new Tuple<string, int>(string.Join(" ", nameBeer).Trim(), int.Parse(input[input.Length - 1]));
            Console.WriteLine(beerTuple);

            input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var lastTuple = new Tuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));
            Console.WriteLine(lastTuple);


        }
    }
}
