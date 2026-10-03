using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Rabbit : Animal
    {
        public string CannotSwim = "";//Will change this one later.

        //Class property.
        public bool OnGround { get; set; } //Will move this later.

        public string Sound = "Kaninen stampar! Nu är den arg!";
        public string Habits = " gräver sig ner i jorden. Till skillnad ifrån harar som bara gräver gryt så gör kaniner hela tunnlar.";
        
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

            Console.WriteLine(Name + Habits);

            Console.WriteLine("");
            

        }

        public void PickUp()
        {
            bool onGround = false;

            Console.WriteLine(Name + " blir inte glad av att bli upplockad.");
            Console.WriteLine("Hon börjar " + Sound + " av vrede!");

        }
    }
}
