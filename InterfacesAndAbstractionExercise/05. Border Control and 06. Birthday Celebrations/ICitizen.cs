using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Border_Control
{
    public interface ICitizen : IMigrant, IBirthtable
    {
        string Name { get; }
        int Age { get; }
       
    }
}
