using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CommandInterpretator
    {
        private Structure<string> collection = new Structure<string>();

        public void ExecuteCommand(string input)
        {

            var command = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            switch (command[0])
            {
                case "Add":
                    collection.Add(command[1]);
                    break;

                case "Remove":
                    collection.Remove(int.Parse(command[1]));
                    break;

                case "Contains":
                    Console.WriteLine(collection.Contains(command[1]));
                    break;

                case "Greater":
                    Console.WriteLine(collection.CountGreaterThan(command[1]));
                    break;

                case "Max":
                    Console.WriteLine(collection.Max());
                    break;

                case "Min":
                    Console.WriteLine(collection.Min());
                    break;

                case "Swap":
                    collection.Swap(int.Parse(command[1]), int.Parse(command[2]));
                    break;

                case "Print":
                    var toPrint = collection.GetList();

                    foreach (var item in toPrint)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case "Sort":
                    collection = Sorter<string>.Sort(collection);
                    break;

            }
        }
    }
}

