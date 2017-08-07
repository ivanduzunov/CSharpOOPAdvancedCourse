using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfacesEx.Interfaces
{
    public interface IPerson
    {
        string Name { get; }
        int Age { get; }
        void GetName();
    }
}
