namespace Part_4._5___Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER for a joke:");
            Console.ReadLine();
            Joke(99);
        }

        public static void Joke(int numBugs)
        {
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine(numBugs + " little bugs");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine((numBugs + 1) + " little bugs in the code");
        }
    }
}
