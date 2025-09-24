using System.Runtime.InteropServices;

namespace AssignmentGithubOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Myths class and giving it values
            Myths firstMyth = new Myths(
                "Baba Yaga",
                "Slavic folklore",
                "\nA witch-like old woman living in a hut that stands on chicken legs. \nShe’s both a helper and a villain, giving quests or devouring intruders.",
                "\nHer role is often a test — she isn’t purely evil; \nshe’s a gatekeeper to knowledge, and those who approach her correctly can get immense power or wisdom."); //creating myth object

            firstMyth.writeOutMyth(); // Calling the method to write out the myth information
        }
    }
}
