using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlackBoxInteger
{
    public class Program
    {
        private const BindingFlags NonPulbicFlags = BindingFlags.Instance | BindingFlags.NonPublic;
        public static void Main(string[] args)
        {
            Type blackBoxType = typeof(BlackBoxInt);
            BlackBoxInt myBlackBox = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);

            var input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split('_');
                var method = tokens[0];
                var value = int.Parse(tokens[1]);

                blackBoxType.GetMethod(method, NonPulbicFlags).Invoke(myBlackBox, new object[] {value});
                var innerValue = blackBoxType.GetFields(NonPulbicFlags).First().GetValue(myBlackBox);
                Console.WriteLine(innerValue);
            }
        }
    }
}
