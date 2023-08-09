using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class12
{

    
    public class Food
    {
        public const double TAX = 2.00;

        public string FoodName;
        public double PriceFood;
        public string Extra;
    }

    public class Menu
    {
        public List<Drink> Drinks { get; set; }
        public List<Food> Foods { get; set; }
    }

    public class Drink
    {
        public const double TAX = 2.00;

        public string DrinkName;
        public double PriceDrink;

        public string CheckVailedInput(string inputFromUser)
        {
            if (string.IsNullOrEmpty(inputFromUser))
            {
                throw new Exception("null");
            }
  
            if(inputFromUser == "y")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Ok, What Drink would you like?");
                Console.WriteLine("Drink List");
                return "y";
                

            }
            else if (inputFromUser == "n")
            {

               
                return "n ";
            }
            else
            {
                return "InvalidInput";
            }
        }

    }
    public class Restaurant
    {
        public double Amount;
    }
}



