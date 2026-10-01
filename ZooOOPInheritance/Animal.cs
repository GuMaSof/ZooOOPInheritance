using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Animal
    {
        //Sound
        public string Sound { get; set; }
        //Habits.
        public string Personality { get; set; }
        //Name of the animal.
        public string Name { get; set; }
        //Fur Constructor.
        public string Fur { get; set; }
        //Tail.
        public string Tail { get; set; }




        //MakeSound Method for making some noise. Originally I called this method "MakeSomeNoise".
        public virtual void MakeSound()
        {
            Console.WriteLine("Nu hör du " + Name + "Oj vad hon låter!");
        }
        //RunMethod for seeing how fast the animal can run and for what reason.
        public virtual void Run()
        {
            Console.WriteLine("Kolla hur snabbt den rör sig! Helt otroligt!");
        }
        //Behaviour for displaying the various different habits of the animals.
        public virtual void Behaviour()
        {
            Console.WriteLine("Se hur skygg varelsen är!");
        }
    }
}
