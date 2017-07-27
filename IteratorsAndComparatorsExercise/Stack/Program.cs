using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            var customStack = new CustomStack<string>();

            var input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Push":
                        var elements = tokens.Skip(1).Take(input.Length - 1).ToArray();
                        customStack.Push(elements);
                        break;

                    case "Pop":
                        customStack.Pop();
                        break;
                }
               
            }
            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
