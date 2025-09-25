namespace AssignmentGithubOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myth1Wendigo Wendigo = new myth1Wendigo();

            Wendigo.mythName = "Wendigo";
            Wendigo.mythOrigin = "Algonquian (First Nations / Native American) mythology";
            Wendigo.mythFact = "It is a malevolent cannibal spirit associated with winter, hunger, and greed. " +
                "\nOften depicted as gaunt, with a heart of ice and insatiable appetite. " +
                "\nIn some traditions, you don’t just meet a wendigo — you become one when you let hunger, greed, or taboo actions consume you. " +
                "\nIt’s more of a moral warning than a monster.";


            Wendigo.writeOutMyth();

            myth2Nuckelavee Nuckelavee = new myth2Nuckelavee();

            Nuckelavee.mythName = "Nuckelavee";
            Nuckelavee.mythOrigin = "Orcadian (Scottish island) folklore";
            Nuckelavee.mythFact = "It is a grotesque horse-like demon with no skin, exposing muscle and veins, its rider fused to its back. " +
                "\nIt spreads disease and blights crops. " +
                "\nIt’s powerless when it rains or near fresh water — a single stream can stop it. Fishermen used that to escape it.";

            Nuckelavee.writeOutMyth();
        }
    }
}
