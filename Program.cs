namespace AssignmentGithubOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pontianak thePontianak = new Pontianak(); // Creating an instance of Pontianak class

            // Setting properties of thePontianak instance
            thePontianak.mythName = "Pontianak";
            thePontianak.mythOrigin = "Indonesia and Malaysia";
            thePontianak.mythFact = "Pontianak is a vampiric female ghost born from women who died during childbirth.\n" +
                "She appears as a pale, beautiful woman with long black hair and a flowery scent — but when she attacks, \n" +
                "she turns monstrous, tearing out organs with her nails." +
                "\nHer presence is announced by the smell of frangipani flowers and a baby’s cry. " +
                "\nIf you hear the baby cry softly, she’s far away; if it’s loud, she’s right behind you.";

            thePontianak.writeOutMyth(); // Writing out the myth information
        }
    }
}
