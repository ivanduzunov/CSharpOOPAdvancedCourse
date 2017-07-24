using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CommandInterpretator ci = new CommandInterpretator();
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                ci.ExecuteCommand(input);
            }
        }
    }
}
