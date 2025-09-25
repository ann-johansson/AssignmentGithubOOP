using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGithubOOP
{
    public class Pontianak : Myths // Derived class from Myths
    {
        public override void writeOutMyth() // Overriding the method from Myths class
        {
            Console.WriteLine($"Now I am gonna tell you an interesting fact about {mythName}, a myth which originates from {mythOrigin}.\n{mythFact}");
        }
    }
}
