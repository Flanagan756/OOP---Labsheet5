using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet5
{
    public static class Program
    {
        static void Main(string[] args)
        {
           // Game g1 = new Game("Monopoly", 19.99m, new DateTime(1970, 01, 31));
           // Game g2 = new Game(){ Price = 10.99m, ReleaseDate = new DateTime(2000, 6, 15)};

            ComputerGame cg1 = new ComputerGame("Sonic", 7.99m, new DateTime(1991, 10, 09),"7");
            ComputerGame cg2 = new ComputerGame("Skyrim", 44.99m, new DateTime(2010, 10, 03), "15");

            Console.WriteLine("{0,-15}{1,-15}{2,-30}{3,-15}", "NAME", "PRICE", "RELEASE DATE", "PEGI");
         // DisplayGame(g1);
         // DisplayGame(g2);
            DisplayGame(cg1);
            DisplayGame(cg2);

            int result = 23.By2Less1();
            string text = "this is a test sentance";

            Console.WriteLine("The number of words in \"{0}\" is {1}",text, text.WordCount());

            Console.WriteLine(result);
           

        }
        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
     
        public static int WordCount(this string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }

        public static int By2Less1(this int num)
        {
            return num * 2 - 1;
        }
    }
}
