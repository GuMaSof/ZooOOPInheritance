using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class BlackTailedJackRabbit : Rabbit
    {
        //Property of class.
        protected string eyes = "Ögonen är uppspärrade";
        public BlackTailedJackRabbit(string sound, string habits, string name, string fur, string tail, string grunt, string eyes) : base(sound, habits, name, fur, tail, grunt)
        {
            //Property of own class.
            this.eyes = eyes;
            //Assigning values to inherited variables from the upper class Animal.
            name = "Långben";
            fur = "Kort och brun";
            tail = "Fluffig, kort och svart";
        }
    }
}
