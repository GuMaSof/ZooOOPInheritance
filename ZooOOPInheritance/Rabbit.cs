using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Rabbit : Animal
    {
        //Class property.
        public bool OnGround { get; set; }

        

        //MakeSound
        public override void MakeSound()
        {
            string stomp = "Nä, nu stampar " + Name + "! Nu är hon arg!";
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
            Console.WriteLine("Kaninen gräver sig ner i jorden.");
            
        }
        
        //Dig method.
        public void PickUp()
        {
            bool onGround = false;

            Console.WriteLine(Name + " blir inte glad av att bli upplockad.");
            Console.WriteLine("Hon börjar " + Sound + " av vrede!");
        }
    }
}
