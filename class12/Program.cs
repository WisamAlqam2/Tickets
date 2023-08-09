using System;
using System.Collections.Generic;

namespace class12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Food menu and drinks in my restaurant

            Console.WriteLine("Food List");

            var foodList = GetDrinkList("F").Foods;

            for (int i = 0; i < foodList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {foodList[i].FoodName} - {foodList[i].PriceFood}");
            }

            Console.WriteLine();

            Console.Write("Choose the Food you want: ");
            int foodChoice;
            while (!int.TryParse(Console.ReadLine(), out foodChoice) || foodChoice < 1 || foodChoice > foodList.Count)
            {
                Console.Write("Please enter a valid choice: ");
            }

            Food selectedFood = foodList[foodChoice - 1];
            var drink = new Drink();

            Console.Write("Would you like a drink with that? (y/n):\n ");
            string userInput = Console.ReadLine();

            var fromDrink = drink.CheckVailedInput(userInput);
            while (fromDrink == "InvalidInput")
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'");
                Console.Write("Would you like a drink with that? (y/n): ");
                userInput = Console.ReadLine();
                fromDrink = drink.CheckVailedInput(userInput);
            }

            if (userInput == "y")
            {

                List<Drink> drinkList = GetDrinkList("D").Drinks;
                for (int i = 0; i < drinkList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {drinkList[i].DrinkName} - {drinkList[i].PriceDrink}");
                }
                int drinkChoice;

                Console.Write("\nChoose the Drink you want: ");
                while (!int.TryParse(Console.ReadLine(), out drinkChoice) || drinkChoice < 1 || drinkChoice > drinkList.Count)
                {
                    Console.Write("Please enter a valid choice: ");
                }
                
                Drink selectedDrink = drinkList[drinkChoice - 1];
                Console.WriteLine($" {selectedFood.FoodName} - {selectedFood.PriceFood} and {selectedDrink.DrinkName} - {selectedDrink.PriceDrink}");


                var Amount = selectedFood.PriceFood + selectedDrink.PriceDrink;

                Console.Write("Amount :");
                Console.Write(Amount);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Thank You");
            Console.ReadKey();

            Console.WriteLine($" {selectedFood.PriceFood}");

        }

        private static Menu GetDrinkList(string type)
        {
            var menu = new Menu();

            if (type == "D")
            {
                var drinkList = new List<Drink>
                {
                    new Drink { DrinkName = "Coffee",           PriceDrink = 25 },
                    new Drink { DrinkName = "Coffee With Milk", PriceDrink = 30 },
                    new Drink { DrinkName = "Tea",              PriceDrink = 20 },
                    new Drink { DrinkName = "Green Tea",        PriceDrink = 25 },
                    new Drink { DrinkName = "Cola With Ice",    PriceDrink = 30 },
                    new Drink { DrinkName = "Lemon",            PriceDrink = 20 },
                    new Drink { DrinkName = "Mint lemon",       PriceDrink = 20 }

                };

                menu.Drinks = drinkList;

                return menu;


            }

            if (type == "F")
            {
                var foodList = new List<Food>
                 {
                new Food { FoodName = "kitech",          PriceFood = 25 },
                new Food { FoodName = "Fish",            PriceFood = 30 },
                new Food { FoodName = "Burgar",          PriceFood = 20 },
                new Food { FoodName = "kebab",           PriceFood = 25 },
                new Food { FoodName = "Hummus and meat", PriceFood = 30 },
                new Food { FoodName = "Prost",           PriceFood = 20 }
                 };

                menu.Foods = foodList;

                return menu;
            }
            return null;
        }


    }


}




