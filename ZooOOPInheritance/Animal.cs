using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Animal
    {
        //Sound
        public string Sound;
        //Habits.
        public string Personality;
        //NumberOfLegs.
        public string Name;
        //Fur Constructor.
        public string Fur;
        //Tail.
        public string Tail;

        
        public Animal (string sound, string personality, string name, string fur, string tail)
        {
            Sound = sound;
            Personality = personality;
            Name = name;

            Fur = fur;
            Tail = tail;
        }

        //MakeSound Method for making some noise. Originally I called this method "MakeSomeNoise".
        public virtual void MakeSound(string name)
        {
            Console.WriteLine("Nu hör du " + name + "Oj vad hon låter!");
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
