using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet5
{
    class Game
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

        public Game() : this("unkown", 0, DateTime.Now)
        {

        }

        public override string ToString()
        {
            return string.Format($"{Name,-15}{Price,-15}{ReleaseDate,-15}");
        }
     
    }
}
