using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet5
{
    public class ComputerGame :  Game
    {
        public string PEGI_Rating { get; set; }

        public ComputerGame(string name, decimal price, DateTime date, string pegi)
        : base(name, price, date) //connects to the other class which has these properties
        {
            PEGI_Rating = pegi; //adds on its own property
        }

        public override string ToString()
        {
            return string.Format($"{base.ToString(),-15}{PEGI_Rating,-15}");
        }
        public decimal GetDiscountPrice()
        {
            return Price * .9m;
        }
        public override void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
            Console.WriteLine("Updating the price");
        }

    }
}
