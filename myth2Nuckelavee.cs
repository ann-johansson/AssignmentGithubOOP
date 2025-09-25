using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGithubOOP
{
    internal class myth2Nuckelavee : Myths
    {
        public override void writeOutMyth()
        {
            Console.WriteLine($"In {mythOrigin} there's also {mythName}. Here are some facts about {mythName}: \n{mythFact}");
        }

    }
}
