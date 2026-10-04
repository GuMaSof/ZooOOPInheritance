namespace ZooOOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit("stampar", "gräver.", "Nellie", "Lång och brun", "Fluffig", "grymta");

            Animal animal = new Animal("Mjau", "skygg", "Malte", "långt", "lång och yvig");

            Lynx lynx = new Lynx("Mjau", "skär köttet i små delar", "Amadeus", "Kort of gulbrun",
                "Kort", "klättrar i ett träd");

            Marmot marmot = new Marmot("låter ju som en fågel!", "gräver", "Otto", "Kort och brungrå",
                "Kort", "tar tag i maten");

            SwampRabbit swampRabbit = new SwampRabbit("stampar", "gräver.", "Louise", "Kort och brun",
                "Fluffig och kort", "grymta", "kan simma!");

            BlackTailedJackRabbit longLegs = new BlackTailedJackRabbit("stampar", "gräver.",
                "Långben", "Kort och brun", "Fluffig, svart och kort", "grymta",
                "Ögonen är uppspärrade", "Och öronen är väldigt stora");

            //Variables necessary for menu structure.
            bool menuLoop = true;
            string inputString = ""; //Unconverted user input stored here.
            int inputInteger; //Converted userInput stored here.

            while (menuLoop = true)
            {
                Console.WriteLine("Välkommen till OOP ZOO!");
                Console.WriteLine("Vi kan stolt säga att vi har ett brett utbud på gnagare.");

                Console.WriteLine("Exempelvis så har vi murmeldjur från Alperna, ");
                Console.WriteLine("träskkaniner från Louisiana och åsnesvansharar ifrån Nordamerika.");

                Console.WriteLine("Men om ni måste insistera på att få se rovdjur så har vi lodjur också.");
                Console.WriteLine("Om det kan tänkas finnas finnas ett djur som ni är mer intresserad av,");
                Console.WriteLine("säg bara till.");

                Console.WriteLine("Tryck [1] för att få se ett murmeldjur");
                Console.WriteLine("Tryck [2] för att se en träskkanin.");
                Console.WriteLine("Tryck [3] för att få se en åsnesvanshare");

                Console.WriteLine("Tryck [4] för att få se ett lodjur");
                Console.WriteLine("Tryck [5] för att få se ett annat djur.");
            }
        }
    }
}