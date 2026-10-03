using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Lynx : Animal
    {
        protected string climbTree = "klättrar i trädet";
        public Lynx(string sound, string habits, string name, string fur, string tail, string climbTree) : base(sound, habits, name, fur, tail)
        {
            this.climbTree = climbTree;
            //Assigning values to inherited variables from the upper class Animal.
            sound = "Mjau";
            habits = "Skär kött i smådelar innan han äter.";
            name = "Amadeus";

            fur = "Kort of gulbrun";
            tail = "Kort";
        }
    }
}
