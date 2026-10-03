namespace ZooOOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit("grymta", "gräver.", "Nellie", "Lång och brun", "Fluffig", "stampar", false);

            Animal animal = new Animal("Mjau", "skygg", "Malte", "långt", "lång och yvig");

            Lynx lynx = new Lynx("Mjau", "skär köttet i små delar", "Amadeus", "Kort of gulbrun", "Kort", "klättrar i ett träd");

            Marmot marmot = new Marmot("låter ju som en fågel!", "gräver", "Otto", "Kort och brungrå", "Kort", "tar tag i maten");

        }
    }
}