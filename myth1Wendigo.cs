using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGithubOOP
{
    public class myth1Wendigo : Myths
    {

        public override void writeOutMyth()
        {
            Console.WriteLine($"{mythName} is a myth that is {mythOrigin}. Some interesting facts is that: \n{mythFact}\n");
        }

    }
}
