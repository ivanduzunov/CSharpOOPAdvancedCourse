using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttributeAndEnumeration
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class, AllowMultiple = true)]
    public class MySampleAttribute : Attribute
    {
        private string author;
        private string dateMande;

        public MySampleAttribute(string author, string dateMade)
        {
            this.Author = author;
            this.dateMande = dateMade;
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string DateMade
        {
            get { return dateMande; }
            set { dateMande = value; }
        }

    }
}
