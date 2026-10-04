namespace ZooOOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Immidiate design of objects of the relevant classes from the very start.
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

            //Variables necessary for menu structure. I have chosen to have multiple different variables for different menus to minimize potential errors.
            bool menuLoop = true;

            string inputString1; //Unconverted user input for main menu stored here.
            string inputString2; //Unconverted input user input for animal menu here.

            int inputInteger1; //Converted user input from main menu stored here.
            int inputInteger2; //Converted userInput from animal menu stored here.

            //Laying groundwork for menu structure with a while loop that may be turned of later with bool value.
            while (menuLoop == true)
            {
                Console.Clear(); //Cleans up the console from excessive info.
                Console.WriteLine("Välkommen till OOP ZOO!");
                Console.WriteLine("Vi kan stolt säga att vi har ett brett utbud på gnagare.");

                Console.WriteLine("Exempelvis så har vi murmeldjur från Alperna, ");
                Console.WriteLine("träskkaniner från Louisiana och åsnesvansharar ifrån Nordamerika.");

                Console.WriteLine("Men om ni måste insistera på att få se rovdjur så har vi lodjur också.");
                Console.WriteLine("Om det kan tänkas finnas finnas ett djur som ni är mer intresserad av,");
                Console.WriteLine("säg bara till.");

                Console.WriteLine("Tryck [1] för att få se på ett av dom nämnda djuren.");
                Console.WriteLine("Tryck [2] för att se ett annat djur.");
                Console.WriteLine("Tryck [3] för att lämna OOP Zoo.");

                //User input.
                inputString1 = Console.ReadLine();

                /*Safety system against wrong input, such as unconvertable symbols, like letters.
                 * But additionally numbers that are either two high or two low.
                 * Of course we also have conversion of strings when possible here as well.
                 
                 In summary this if-statement does not handle the overall selection of the menu structure,
                so much as it manages potential errors that may inconvience our intended purpose.*/ 
                if (Int32.TryParse(inputString1, out inputInteger1))
                {
                    /*I have chosen to split up the choices into two different menu setups to minimize text on the console.
                     * I call this menu the "Main menu"*/
                    switch (inputInteger1)
                    {
                        case 1:
                            Console.Clear(); //Cleans up the console from excessive info.
                            Console.WriteLine("Tryck [1] för att få se ett murmeldjur");

                            Console.WriteLine("Tryck [2] för att se en vanlig kanin");
                            Console.WriteLine("Tryck [3] för att se en träskkanin.");
                            Console.WriteLine("Tryck [4] för att få se en åsnesvanshare");

                            Console.WriteLine("Tryck [5] för att få se ett lodjur.");

                            //I call this one the "Animal menu".
                            switch (inputInteger1)
                            {
                                case 1:
                                    Console.WriteLine("Murmeldjur alltså! Vilket roligt val!");
                                    Console.WriteLine("Vårt murmeldjur heter Otto.");

                                    Console.WriteLine("Välj [1] för att få höra murmeldjurets läte.");
                                    Console.WriteLine("Välj [2] för att se på murmeldjurets beteende.");

                                    Console.WriteLine("Välj [3] för att mata murmeldjuret.");
                                    Console.WriteLine("Välj [4] för att få murmeldjuret att gå.");
                                    break;
                                case 2:
                                    Console.WriteLine("Kanin alltså! Vilket roligt val!");

                                    Console.WriteLine("Välj [1] för att få höra kaninens läte.");
                                    Console.WriteLine("Välj [2] för att se på kaninens beteende.");

                                    Console.WriteLine("Välj [3] för att plocka upp kaninen.");
                                    Console.WriteLine("Välj [4] för att få kaninen att gå.");
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 2:
                            break;
                        case 3:
                            Console.WriteLine("Hejdå!");
                            menuLoop = false;
                            break;
                    }
                    

                    
                }
                else if (inputInteger1 == 0 || inputInteger1 > 2)
                {
                    Console.WriteLine("Error! Du måste skriva antingen 1 eller 2.");
                }
                else
                {
                    Console.WriteLine("Error. Du måste skriva en siffra!");
                }

            }
        }
    }
}