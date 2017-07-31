using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InfernoInfinity
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomAttribute : Attribute
    {
        public CustomAttribute(string author, int revision, string description, params string[] reviewers)
        {
            Author = author;
            Revision = revision;
            Description = description;
            Reviewers = new List<string>(reviewers);
        }
        public string Author { get; private set; }
        public int Revision { get; private set; }
        public string Description { get; private set; }
        public List<string> Reviewers { get; private set; }

    }
}
