using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Rabbit : Animal
    {
        //Class property.
        protected bool canSwim = false;
        //Will put my constructor here.
        public Rabbit (string sound, string habits, string name, string fur, string tail, bool canSwim) : base(sound, habits, name, fur, tail)
        {
            this.canSwim = canSwim;
        }

        
        //MakeSound
        public override void MakeSound()
        {
            string stomp = "Nä," + sound + name + "! Nu är hon arg!";
            Console.WriteLine(stomp);
        }
        //Run
        public override void Run()
        {
            Console.WriteLine(name + " blir rädd och hoppar ned i sin håla där den känner sig säker.");
        }
        //Behaviour unique to rabbits.
        public override void Behaviour()
        {

            Console.WriteLine(name + habits);
        }

        public void PickUp()
        {
            Console.WriteLine(name + " blir inte glad av att bli upplockad.");
            Console.WriteLine("Hon börjar " + sound + " av vrede!");

        }
    }
}
