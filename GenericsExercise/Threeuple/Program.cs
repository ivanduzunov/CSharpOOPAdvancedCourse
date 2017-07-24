using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nameInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var nameTokens = nameInput.Take(nameInput.Count - 2);
            var name = string.Join(" ", nameTokens);
            var adress = nameInput[nameInput.Count - 2];
            var city = nameInput[nameInput.Count - 1];
            var threeuple = new Threeuple<string, string, string>(name, adress, city);
            Console.WriteLine(threeuple);

            var beerInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var beerTokens = beerInput.Take(beerInput.Count - 2);
            var beername = string.Join(" ", beerTokens);
            var liters = int.Parse(beerInput[beerInput.Count - 2]);
            bool drunk = beerInput[beerInput.Count - 1] == "drunk";
            var beerThreeuple = new Threeuple<string, int, bool>(beername, liters, drunk);
            Console.WriteLine(beerThreeuple);

            var bankInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var bankTokens = bankInput.Take(bankInput.Count - 2);
            var personName = string.Join(" ", bankTokens);
            var balance = double.Parse(bankInput[bankInput.Count - 2]);
            var bankName = bankInput[bankInput.Count - 1];
            var bankThreeuple = new Threeuple<string, double, string>
                (personName, balance, bankName);
            Console.WriteLine(bankThreeuple);
        }
    }
}
