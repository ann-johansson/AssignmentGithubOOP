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
        private string mythSecret; // Private field for secret information, this is the encapsulation part


        // Constructor to get the myth information
        public Myths(string name, string origin, string fact, string secret)
        {
            mythName = name;
            mythOrigin = origin;
            mythFact = fact;
            mythSecret = secret;
        }

        public void writeOutMyth() // Method to write out the myth information
        {
            Console.WriteLine($"Now I am gonna tell you an interesting fact about {mythName}, a myth which originates from {mythOrigin}. {mythFact}" +
                $" There's also a secret: {mythSecret}");
        }
    }
}
