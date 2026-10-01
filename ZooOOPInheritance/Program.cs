namespace ZooOOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Here we decide what noise the rabbit makes, her personality, her number of legs, her fur, tail,
             * and if she is currently standing on the ground.
             * The last one is very important for the mood of rabbits.*/
            Rabbit rabbit = new Rabbit("grymta", "rebellious", "Nellie", "Lång brun päls", "Fluffig och kort", true);
            
            rabbit.PickUp(rabbit.Name, rabbit.Sound);
            rabbit.MakeSound(rabbit.Name);
            rabbit.Run();

            rabbit.Behaviour();
        }
    }
}