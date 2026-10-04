using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class BlackTailedJackRabbit : Rabbit
    {
        //Property of class.
        protected string eyes = "Ögonen är uppspärrade";
        protected string ears = "Och öronen är väldigt stora";
        public BlackTailedJackRabbit(string sound, string habits, string name, string fur, string tail, string grunt, string eyes, string ears) : base(sound, habits, name, fur, tail, grunt)
        {
            //Property of own class.
            this.eyes = eyes;
            this.ears = ears;
            //Assigning values to inherited variables from the upper class Animal.
            name = "Långben";
            fur = "Kort och brun";
            tail = "Fluffig, kort och svart";
        }

        //Methods down here.
        public void LookAtJackRabbit()
        {
            Console.WriteLine("Nä den här haren är ju läskig!");
            Console.WriteLine(eyes + " som att " + name + " vore vansinnig.");
            Console.WriteLine(ears + ", kanske större än huvudet.");

            Console.WriteLine("Benen är också ohyggligt avlånga.");
        }
    }
}
