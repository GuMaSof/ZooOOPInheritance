using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Animal
    {
        /* I have chosen to write complete syntax over the simplified one,
         * because I want to have a proper constructor,
         * after deliberation about what the purpose of a constructor is and how it shall fit into this project.
         Particularly in relation to the user.
        
         I had previously been worried that a user would be confused by usage of the constructor,
        and it's enormous requirements for various forms of input.
        However I now believe that it shall be fine if we design a menu structure,
        with much and clear commmunication offered.*/
        private string sound;
        private string habits;
        private string name;

        private string fur;
        private string tail;
        //Sound
        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        //Habits.
        public string Habits
        {
            get { return habits; }
            set { habits = value; }
        }
        //Name of the animal.
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //Fur Constructor.
        public string Fur
        {
            get { return fur; }
            set { fur = value; }
        }
        //Tail.
        public string Tail
        {
            get { return tail; }
            set { tail = value; }
        }

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
            Console.WriteLine("Djuret gömmer sig. Se hur skyggt det är!");
        }
    }
}
