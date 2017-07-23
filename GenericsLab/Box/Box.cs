using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box<T>
{
    private List<T> data;

    public Box()
    {
        this.data = new List<T>();
    }
    public void Add(T element)
    {
        this.data.Add(element);
    }

    public T Remove()
    {
        var toReturn = this.data.Last();
        this.data.RemoveAt(this.data.Count - 1);
        return toReturn;
    }

    public int Count => this.data.Count;
}

