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

<<<<<<< HEAD
        //Non-physical traits of the animals.
        private string sound = "Nu hör du djuren! Oj vad dom låter!";
        private string habits = "Se hur skygg varelsen är!";
        //Physical traits of the animals.
        private int numberOfLegs = 4;
        private string fur = "Lång päls för att hålla djuret varmt.";
        private string tail = "Det här djuret har en lång svans.";
        //Sound constructor
        //
=======


>>>>>>> bef7e521ad41d8cec950ee1c4e1673c1e424c53a

        //MakeSound Method for making some noise. Originally I called this method "MakeSomeNoise".
        public virtual void MakeSound()
        {
<<<<<<< HEAD
            Console.WriteLine(sound);
=======
            Console.WriteLine("Nu hör du " + Name + "Oj vad hon låter!");
>>>>>>> bef7e521ad41d8cec950ee1c4e1673c1e424c53a
        }
        //RunMethod for seeing how fast the animal can run and for what reason.
        public virtual void Run()
        {
            Console.WriteLine("Kolla hur snabbt den rör sig! Helt otroligt!");
        }
        //Behaviour for displaying the various different habits of the animals.
        public virtual void Behaviour()
        {
            Console.WriteLine(habits);
        }
    }
}
