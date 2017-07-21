using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Border_Control
{
    public interface IPet : IBirthtable
    {
        string Name { get; }     
    }
}
