using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Animal();
        }

        static void Animal()
        {
            Console.WriteLine("Que som fazem os morcegos?");
        }
    }

    public class Bat
    {
        public void Animal()
        {
            Console.WriteLine("Que som fazem os morcegos?");
        }
    }
}
