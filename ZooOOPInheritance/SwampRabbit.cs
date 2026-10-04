using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class SwampRabbit: Rabbit
    {
        protected string canSwim = "kan simma!";
        public SwampRabbit(string sound, string habits, string name, string fur, string tail, string grunt, string canSwim) : base(sound, habits, name, fur, tail, grunt)
        {
            //Providing access to protected variables above in this class.
            this.canSwim = canSwim;

            //Assigning values to inherited variables from the upper class Animal.
            name = "Louise";
            fur = "Kort och brun";
            tail = "Fluffig och kort";
        }

        //MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Nä, " + name + " " + sound + "! Nu är hon arg!");
        }
        //Run
        public override void Run()
        {
            Console.WriteLine(name + " blir rädd och hoppar ned i sin håla där hon känner sig säker.");
        }
        //Behaviour unique to rabbits.
        public override void Behaviour()
        {

            Console.WriteLine(name + " " + habits);
        }
        //Unique method of Swamp Rabbit.
        public void Bathe()
        {
            Console.WriteLine("Ser man på, " + name + " " + canSwim);
            Console.WriteLine("Detta beror på att " + name + " är en träskkanin ifrån Louisiana.");
        }
    }
}
