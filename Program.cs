namespace AssignmentGithubOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            japaneseMyth Kitsune = new japaneseMyth(); // Creating an object of the inherited class

            Kitsune.mythName = "Kitsune"; // Assigning name
            Kitsune.mythOrigin = "Japan"; // Assigning origin
            Kitsune.mythFact = "\nThey are fox spirits who can shapeshift into humans (often beautiful women), " +
                "\nknown for trickery, intelligence, and longevity; " +
                "\ntails multiply as they age (up to nine).\n"; // Assigning facts

            Kitsune.tellBranchAssignment(); // Telling about the branch assignment in a WriteLine

            Kitsune.writeOutMyth(); // Writing out the myth information
        }
    }
}
