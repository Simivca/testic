namespace Git
{
    class Program
    {
        public static void Print(string words)
        {
            Console.WriteLine(words);
        }
        static void Main(string[] args)
        {
            Print("Hi");
            Print("Bye");
            Print("Hi again");
            Print("Really cool feature");
        }
    }
}