﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace CollectionHierarhy.Interfaces
{
    public interface IAddRemoveCollection<T> : IInitialCollection<T>, IRemovableCollection<T>
    {
        
    }
}
