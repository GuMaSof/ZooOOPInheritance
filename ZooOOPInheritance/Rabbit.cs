using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Rabbit : Animal
    {
        //Class property.
        private bool OnGround;

        //Constructor of class properties.
        public Rabbit(string sound, string personality, string name, string fur, string tail, bool onGround) : base (sound, personality, name, fur, tail)
        {
            Personality = personality;
            OnGround = onGround;
        }
        
        //MakeSound
        public override void MakeSound(string name)
        {
            string stomp = "Nä, nu stampar" + name + "! Nu är hon arg!";
            Console.WriteLine(stomp);
        }
        //Run
        public override void Run()
        {
            Console.WriteLine("Kaninen blir rädd och hoppar ned i sin håla där den känner sig säker.");
        }
        //Behaviour unique to rabbits.
        public override void Behaviour()
        {
            Console.WriteLine("Kaninen gräver sig ner i jorden.");
            
        }
        
        //Dig method.
        public void PickUp(string name, string sound)
        {
            bool onGround = false;

            Console.WriteLine(name + " blir inte glad av att bli upplockad.");
            Console.WriteLine("Hon börjar " + sound + " av vrede!");
        }
    }
}
