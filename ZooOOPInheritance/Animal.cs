using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Animal
    {
        /*I have chosen to write in complete syntax here for the sake of the learning experience.
        Last time I wrote a constructor in the workshop I had taken the easy path.*/

        //Non-physical traits of the animals.
        private string sound;
        private string habits;
        //Physical traits of the animals.
        private int numberOfLegs;
        private string fur;
        private string tail;
        //Sound 
        public string Sound
        {
            
        }

        //Habits 
        public string Habits;

        //NumberOfLegs 
        public int NumberOfLegs;
        //Fur Constructor
        public string Fur;
        //Tail 
        public string Tail;

        //MakeSound Method for making some noise. Originally I called this method "MakeSomeNoise".
        public virtual void MakeSound()
        {
            Console.WriteLine("Nu hör du djuren! Oj vad dom låter!");
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
