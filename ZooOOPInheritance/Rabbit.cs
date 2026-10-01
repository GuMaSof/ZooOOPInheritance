using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOPInheritance
{
    internal class Rabbit : Animal
    {
        
        //MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Kaninen stampar! Nu är den arg!");
        }
        //Run
        public override void Run()
        {
            Console.WriteLine("Kaninen blir rädd och hoppar ned i sin håla där den känner sig säker.");
        }
        //Behaviour unique to rabbits.
        public override void Behaviour()
        {
            Console.WriteLine("Kaninen lägger sig på magen för att sova bredvid en annan artfrände.");
            Console.WriteLine(" Men akta dig för att gå för nära, för att då reser dom sig upp igen!");
        }
        //Dig method.
        public static void Dig()
        {
            Console.WriteLine("Kaninen gräver sig ner i jorden. ");
            Console.WriteLine("Till skillnad ifrån harar som bara gräver gryt så gör kaniner hela tunnlar.");
        }
    }
}
