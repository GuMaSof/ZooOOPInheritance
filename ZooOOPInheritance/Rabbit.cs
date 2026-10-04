using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Rabbit : Animal
    {
        //Class property.
        protected string grunt = "grymta";

        //Cnstructor for inheritance from Animal class.
        public Rabbit (string sound, string habits, string name, string fur, string tail, string grunt) : base( sound, habits, name, fur, tail)
        {
            //Providing access to protected the variable above in this class.
            this.grunt = grunt;

            //Assigning values to inherited variables from the upper class Animal.
            sound = "stampar";
            habits = "gräver.";
            name = "Nellie";
            
            fur = "Lång och brun";
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

        public void PickUp()
        {
            Console.WriteLine(name + " blir inte glad av att bli upplockad.");
            Console.WriteLine("Hon börjar " + grunt + " av vrede!");

        }
        
    }
}
