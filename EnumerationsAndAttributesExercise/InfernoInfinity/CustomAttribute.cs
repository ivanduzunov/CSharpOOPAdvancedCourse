using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InfernoInfinity
{
    public class CustomAttribute : Attribute
    {
        public CustomAttribute(string author, int revision, string description, List<string> reviewers)
        {
            Author = author;
            Revision = revision;
            Description = description;
            Reviewers = reviewers;
        }
        public string Author { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }
        public List<string> Reviewers { get; set; }
    }
}
