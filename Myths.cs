using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGithubOOP
{
    public abstract class Myths // Base class
    {
        public string mythName; // Name of the myth
        public string mythOrigin; // Origin of the myth
        public string mythFact; // Interesting fact about the myth

        public abstract void writeOutMyth(); // An abstract method to be implemented by derived classes
    }
}
