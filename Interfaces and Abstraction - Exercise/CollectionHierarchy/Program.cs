using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarhy.Interfaces;
using CollectionHierarhy.Models;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IInitialCollection<string>> list = new List<IInitialCollection<string>>();
            IInitialCollection<string> addCol = new AddCollection<string>();
            IInitialCollection<string> addRemCol = new AddRemoveCollection<string>();
            IInitialCollection<string> myList = new MyList<string>();
            list.Add(addCol);
            list.Add(addRemCol);
            list.Add(myList);

            var input = Console.ReadLine().Split();

            foreach (IInitialCollection<string> collection in list)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(collection.Add(input[i]) + " ");
                }
                Console.WriteLine();
            }

            var toRemove = int.Parse(Console.ReadLine());

            List<IRemovableCollection<string>> remList = new List<IRemovableCollection<string>>
            {
                (IRemovableCollection<string>)list[1],
                (IRemovableCollection<string>)list[2]
            };       
           

            foreach (var col in remList)
            {
                for (int i = 0; i < toRemove; i++)
                {
                    Console.Write(col.Remove() + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
