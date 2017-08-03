using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HarvestingFields
{
    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            HarvestingFields hv = new HarvestingFields();
            Type classType = typeof(HarvestingFields);
            FieldInfo[] fields = classType.GetFields
                (BindingFlags.Instance | BindingFlags.NonPublic
                | BindingFlags.Public | BindingFlags.Static);

            var input = string.Empty;
            while ((input = Console.ReadLine()) != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        PrintPrivateFelds(fields);
                        break;

                    case "public":
                        PrintPublicFelds(fields);
                        break;

                    case "protected":
                        PrintProtectedFelds(fields);
                        break;

                    case "all":
                        PrintAllFelds(fields);
                        break;
                }
            }

           

        }

        public static void PrintPrivateFelds(FieldInfo[] fields)
        {
            foreach (var fieldInfo in fields.Where(f => f.IsPrivate))
            {
                var fieldType = fieldInfo.FieldType.ToString().Split('.').Last();
                Console.WriteLine($"{fieldInfo.Attributes.ToString().ToLower()} {fieldType} {fieldInfo.Name}");
            }
        }
        public static void PrintPublicFelds(FieldInfo[] fields)
        {
            foreach (var fieldInfo in fields.Where(f => f.IsPublic))
            {
                var fieldType = fieldInfo.FieldType.ToString().Split('.').Last();
                Console.WriteLine($"{fieldInfo.Attributes.ToString().ToLower()} {fieldType} {fieldInfo.Name}");
            }
        }
        public static void PrintProtectedFelds(FieldInfo[] fields)
        {
            foreach (var fieldInfo in fields.Where(f => f.IsFamily))
            {
                var fieldType = fieldInfo.FieldType.ToString().Split('.').Last();
                Console.WriteLine($"protected {fieldType} {fieldInfo.Name}");
            }
        }
        public static void PrintAllFelds(FieldInfo[] fields)
        {
            foreach (var fieldInfo in fields)
            {
                var fieldType = fieldInfo.FieldType.ToString().Split('.').Last();
                var accessModifier = string.Empty;
                if (fieldInfo.Attributes.ToString() == "Family")
                {
                    accessModifier = "protected";
                }
                else
                {
                    accessModifier = fieldInfo.Attributes.ToString().ToLower();
                }
                Console.WriteLine($"{accessModifier} {fieldType} {fieldInfo.Name}");
            }
        }
    }
}
