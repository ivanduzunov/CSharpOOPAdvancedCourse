﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfacesEx.Interfaces
{
    public interface IResident
    {
        string Name { get; }
        string Country { get; }
        void GetName();
    }
}
