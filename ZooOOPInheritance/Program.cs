namespace ZooOOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal
            {
                Sound = "Grymta",
                Habits = "Gräva",
                Name = "Nellie",
                Fur = "Lång",
                Tail = "Fluffig"
            };
            animal.Behaviour(); //Shall test changes in the method.
            
        }
    }
}