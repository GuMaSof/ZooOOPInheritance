using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Marmot: Animal
    {
        protected string grab = "tar tag i maten";
        public Marmot(string sound, string habits, string name, string fur, string tail, string grab) : base(sound, habits, name, fur, tail)
        {
            this.grab = grab;
            //Assigning values to inherited variables from the upper class Animal.
            sound = "låter ju som en fågel!";
            habits = "gräver";
            name = "Otto";

            fur = "Kort och brungrå";
            tail = "Kort";
        }

        public override void MakeSound()
        {
            Console.WriteLine(name + " " + sound + " Är detta verkligen en gnagare?");
        }
        //RunMethod for seeing how fast the animal can run and for what reason.
        public override void Run()
        {
            Console.WriteLine(name + " blir rädd och flyr tillbaka till sin håla.");
        }
        //Behaviour for displaying the various different habits of the animals.
        public override void Behaviour()
        {
            Console.WriteLine(name + " samlar på gräs för sin bädd inför sin vinterdvala.");
        }

        public void FeedMarmot()
        {
            Console.WriteLine(name + " " + grab + " och gnager girigt, som att den skulle försvinna.");
        }
    }
}
