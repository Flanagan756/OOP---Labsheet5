using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet5
{
    public abstract /*abstract can't create constructors by child classes e.g computer games can use the properties when creating their own constructors*/ class Game
    {
        private readonly string _name; 
        public string Name
        {
            get
            {
               return _name;
            }
        }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Game(string name, decimal price, DateTime releaseDate)
        {
            _name = name;
            Price = price;
            ReleaseDate = releaseDate;
        }
        //constructor linking
        public Game(string name, decimal price)
            : this(name, price, DateTime.Now) //Default constructor that is still connected to the original constructor format
        {

        }

        public Game() : this("unkown", 0, DateTime.Now) //defult const
        {

        }
        public abstract void UpdatePrice(decimal percentageIncrease); /*Uses this method but the method instructions itself are in ComputerGames.cs*/
        //{
        //    Price *= (1 + percentageIncrease);
        //}


        public override string ToString() //ovverides any reference to the other method based on the current method below
        {
            return string.Format($"{Name,-15}{Price,-15}{ReleaseDate,-15}");
        }

    
     
    }
}
