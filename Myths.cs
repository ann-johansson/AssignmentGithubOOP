using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGithubOOP
{
    public class Myths // Base class
    {
        public string mythName; // Name of the myth
        public string mythOrigin; // Origin of the myth
        public string mythFact; // Interesting fact about the myth

        public virtual void writeOutMyth() // Method to write out the myth information
        {
            Console.WriteLine($"Now I am gonna tell you an interesting fact about {mythName}, a myth which originates from {mythOrigin}. {mythFact}");
        }
    }
}
