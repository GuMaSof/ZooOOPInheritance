using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Rabbit : Animal
    {
        //Class property.
        private bool canSwim = false;
        //Will put my constructor here.
        public Rabbit (string sound, string habits, string name, string fur, string tail, bool canSwim)
        {
            this.canSwim;
        }

        //MakeSound
        public override void MakeSound()
        {
            string stomp = "Nä," + Sound + Name + "! Nu är hon arg!";
            Console.WriteLine(stomp);
        }
        //Run
        public override void Run()
        {
            Console.WriteLine(Name + " blir rädd och hoppar ned i sin håla där den känner sig säker.");
        }
        //Behaviour unique to rabbits.
        public override void Behaviour()
        {

            Console.WriteLine(Name + Habits);
        }

        public void PickUp()
        {
            bool onGround = false;

            Console.WriteLine(Name + " blir inte glad av att bli upplockad.");
            Console.WriteLine("Hon börjar " + Sound + " av vrede!");

        }
    }
}
