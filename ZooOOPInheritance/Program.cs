namespace ZooOOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit("grymta", "gräver.", "Nellie", "Lång och brun", "Fluffig", " stampar ", false);
            rabbit.MakeSound();
        }
    }
}