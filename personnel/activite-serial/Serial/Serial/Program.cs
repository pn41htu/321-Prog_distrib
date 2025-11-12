namespace Serial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Character Gerard = new Character { FirstName = "Gérard", LastName = "Franco", Description = "Adore vraiment le miel"};
            Character Maya = new Character { FirstName = "Maya", LastName = "Yémaya", Description = "Est encore plus fan du miel que Gérard" };

        }
    }
    public class Character
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public Actor PlayedBy { get; set; }
    }

    public class Actor
    {

    }
}
