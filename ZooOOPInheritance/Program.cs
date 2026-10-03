namespace ZooOOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creation of object from Rabbit middle-class. Sounds funny I know, but I think you understand what I mean.
            Rabbit rabbit = new Rabbit();
            //All of the following are methods that give text messages within the console.
            rabbit.Dig();
            rabbit.Behaviour();

            rabbit.MakeSound();
            rabbit.Run();
        }
    }
}