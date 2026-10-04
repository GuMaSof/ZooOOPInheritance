using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Lynx : Animal
    {
        protected string climbTree = "klättrar i ett trädet";
        public Lynx(string sound, string habits, string name, string fur, string tail, string climbTree) : base(sound, habits, name, fur, tail)
        {
            this.climbTree = climbTree;
            //Assigning values to inherited variables from the upper class Animal.
            sound = "Mjau";
            habits = "skär köttet i små delar.";
            name = "Amadeus";

            fur = "Kort of gulbrun";
            tail = "Kort";
        }

        public override void MakeSound()
        {
            Console.WriteLine(sound + " säger " + name);
        }
        //RunMethod for seeing how fast the animal can run and for what reason.
        public override void Run()
        {
            Console.WriteLine(name + " vill inte umgås med människor, så han sticker någon annanstans.");
        }
        //Behaviour for displaying the various different habits of the animals.
        public override void Behaviour()
        {
            Console.WriteLine(name + " har fått mat och " + habits + " innan han äter. Så elegant!");
        }

        public void ClimbTree()
        {
            Console.WriteLine(name + " " + climbTree + ".");
        }
    }
}
