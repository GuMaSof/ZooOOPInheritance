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

            //Variables necessary for menu structure.
            bool menuLoop = true;

            //I have chosen to have multiple different variables for different menus to minimize potential errors.
            string mainMenuInputStr; //Unconverted user input for Main menu stored here.
            string animalMenuInputStr; //Unconverted input user input for Animal menu here.
            string marmotInputStr; //Unconverted input user input for Marmot menu here.

            string rabbitMenuInputStr; //Unconverted input user input for general rabbit menu here.
            string swampRabbitInputStr; //Unconverted input user input for swamp rabbit menu here.
            string jackRabbitInputStr; //Unconverted input user input for black tailed jack rabbit menu here.

            string lynxInputStr; //Unconverted input user input for lynx menu here.

            int mainMenuInputInt; //Converted user input from main menu stored here.
            int animalMenuInputInt; //Converted userInput from animal menu stored here.
            int marmotMenuInputInt; //Converted userInput from Marmot menu stored here.

            int rabbitMenuInputInt; //Converted userinput rabbit menu.
            int swampRabbitInputInt; //Converted userinput swamp rabbit menu.
            int jackRabbitInputInt; //Converted userinput black tailed jack rabbit menu.

            int lynxInputInt;

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
                mainMenuInputStr = Console.ReadLine();

                /*Safety system against wrong input, such as unconvertable symbols, like letters.
                 * But additionally numbers that are either two high or two low.
                 * Of course we also have conversion of strings when possible here as well.
                 
                 In summary this if-statement does not handle the overall selection of the menu structure,
                so much as it manages potential errors that may inconvience our intended purpose.*/ 
                if (Int32.TryParse(mainMenuInputStr, out mainMenuInputInt))
                {
                    /*I have chosen to split up the choices into two different menu setups to minimize text on the console.
                     * I call this menu the "Main menu"*/
                    switch (mainMenuInputInt)
                    {
                        case 1:
                            Console.Clear(); //Cleans up the console from excessive info.
                            Console.WriteLine("Tryck [1] för att få se ett murmeldjur");

                            Console.WriteLine("Tryck [2] för att se en vanlig kanin");
                            Console.WriteLine("Tryck [3] för att se en träskkanin.");
                            Console.WriteLine("Tryck [4] för att få se en åsnesvanshare");

                            Console.WriteLine("Tryck [5] för att få se ett lodjur.");
                            animalMenuInputStr = Console.ReadLine();

                            //Seeking errors in and converts input for the choice of animal in the larger "Animal menu".
                            if (Int32.TryParse(animalMenuInputStr, out animalMenuInputInt))
                            {
                                //I call this one the "Animal menu".
                                switch (animalMenuInputInt)
                                {
                                    case 1:
                                        Console.Clear(); //Cleans up the console from excessive info.
                                        Console.WriteLine("Murmeldjur alltså! Vilket roligt val!");
                                        Console.WriteLine("Vårt murmeldjur heter Otto.");

                                        Console.WriteLine("Välj [1] för att få höra murmeldjurets läte.");
                                        Console.WriteLine("Välj [2] för att se på murmeldjurets beteende.");

                                        Console.WriteLine("Välj [3] för att mata murmeldjuret.");
                                        Console.WriteLine("Välj [4] för att få murmeldjuret att gå.");

                                        marmotInputStr = Console.ReadLine();

                                        if (Int32.TryParse(marmotInputStr, out marmotMenuInputInt))
                                        {
                                            //I will call this the marmot menu from now on.
                                            switch (marmotMenuInputInt)
                                            {
                                                case 1:
                                                    //Marmot sound.
                                                    marmot.MakeSound();

                                                    //Keeps console open long enough to see text string.
                                                    Console.ReadLine();
                                                    break;
                                                case 2:
                                                    marmot.Behaviour();

                                                    //Keeps console open long enough to see text string.
                                                    Console.ReadLine();
                                                    break;
                                                case 3:
                                                    marmot.FeedMarmot();

                                                    //Keeps console open long enough to see text string.
                                                    Console.ReadLine();
                                                    break;

                                                case 4:
                                                    marmot.Run();

                                                    //Keeps console open long enough to see text string.
                                                    Console.ReadLine();

                                                    break;
                                            }
                                        }
                                            break;
                                    case 2:
                                        Console.Clear(); //Cleans up the console from excessive info.
                                        Console.WriteLine("Kanin alltså! Vilket roligt val!");

                                        Console.WriteLine("Välj [1] för att få höra kaninens läte.");
                                        Console.WriteLine("Välj [2] för att se på kaninens beteende.");

                                        Console.WriteLine("Välj [3] för att plocka upp kaninen.");
                                        Console.WriteLine("Välj [4] för att få kaninen att gå.");
                                        break;
                                    case 3:
                                        Console.Clear(); //Cleans up the console from excessive info.
                                        Console.WriteLine("Haha, jag visste att du vill se på den!");
                                        Console.WriteLine("Alla blir så förvånade då dom hör talas om träskkaniner.");
                                        Console.WriteLine("Vår träskkanin heter Louise, föra att hon kommer ifrån Louisiana.");

                                        Console.WriteLine("Välj [1] för att få höra kaninens läte.");
                                        Console.WriteLine("Välj [2] för att se på kaninens beteende.");

                                        Console.WriteLine("Välj [3] för att plocka upp kaninen.");
                                        Console.WriteLine("Välj [4] för att se kaninen simma.");
                                        Console.WriteLine("Välj [5] för att få kaninen att gå.");
                                        break;
                                    case 4:
                                        Console.Clear(); //Cleans up the console from excessive info.
                                        Console.WriteLine("Åsnesvanshare? Vilket intressant val!");
                                        Console.WriteLine("Vår åsnesvanshare heter Långben för att hans ben är mycket längre än på kaninerna.");

                                        Console.WriteLine("Välj [1] för att titta närmare på haren.");
                                        Console.WriteLine("Välj [2] för att få höra harens läte.");
                                        Console.WriteLine("Välj [3] för att se på harens beteende.");

                                        Console.WriteLine("Välj [4] för att plocka upp haren.");
                                        Console.WriteLine("Välj [5] för att få haren att gå.");
                                        break;
                                    case 5:
                                        Console.Clear(); //Cleans up the console from excessive info.
                                        Console.WriteLine("Lodjur! Vad roligt att du är så intresserad av nordens största kattdjur!");
                                        Console.WriteLine("Vårt lodjur heter Amadeus");

                                        Console.WriteLine("Välj [1] för att få höra lodjurets läte.");
                                        Console.WriteLine("Välj [2] för att se på lodjurets beteende.");

                                        Console.WriteLine("Välj [3] för att se lokatten klättra i ett träd.");
                                        Console.WriteLine("Välj [4] för att få lodjuret att gå.");
                                        break;
                                }
                            }
                            else if (animalMenuInputInt == 0 || animalMenuInputInt > 5)
                            {
                                Console.WriteLine("Error! Du måste skriva en siffra mellan 1 och 5.");
                            }
                            else
                            {
                                Console.WriteLine("Error. Du måste skriva en siffra!");
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
                else if (mainMenuInputInt == 0 || mainMenuInputInt > 2)
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