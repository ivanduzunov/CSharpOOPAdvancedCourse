using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _01.ListyIterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var create = Console.ReadLine().Split();
            var elements = create.Skip(1).Take(create.Length - 1).ToArray();
            var iterator = new ListyIterator<string>(elements);

            var input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "Print":
                        iterator.Print();
                        break;

                    case "PrintAll":
                        foreach (var item in iterator)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
