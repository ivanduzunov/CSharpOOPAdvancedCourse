﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static  class ArrayCreator
{
    public static T[] Create<T>(int length, T item)
    {
        T[] array = new T[length];
        return array;
    }

}

