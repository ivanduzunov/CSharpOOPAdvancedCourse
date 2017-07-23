using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        Scale<int> scale = new Scale<int>(1, 2);
        Console.WriteLine(scale.GetHavier());
    }
}

