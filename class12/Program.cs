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

            var foodList = new List<Food>
            {
                new Food { FoodName = "kitech",          PriceFood = 25 },
                new Food { FoodName = "Fish",            PriceFood = 30 },
                new Food { FoodName = "Burgar",          PriceFood = 20 },
                new Food { FoodName = "kebab",           PriceFood = 25 },
                new Food { FoodName = "Hummus and meat", PriceFood = 30 },
                new Food { FoodName = "Prost",           PriceFood = 20 }
            };

            for (int i = 0; i < foodList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {foodList[i].FoodName} - {foodList[i].PriceFood}");
            }

            Console.WriteLine("\n");

            Console.Write("Choose the Drink you want: ");
            int foodChoice;
            while (!int.TryParse(Console.ReadLine(), out foodChoice) || foodChoice < 1 || foodChoice > foodList.Count)
            {
                Console.Write("Please enter again: ");
            }

            Food selectedFood = foodList[foodChoice - 1];

            Console.Write("Would you like a drink with that? (y/n): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "y")
            {
                Console.WriteLine(" ok , what drink would you like?");
                Console.WriteLine("Drink List");

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

                for (int i = 0; i < drinkList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {drinkList[i].DrinkName} - {drinkList[i].PriceDrink}");
                }

                Console.WriteLine("\n");

                Console.Write("Choose the Drink you want: ");
                int drinkChoice;
                while (!int.TryParse(Console.ReadLine(), out drinkChoice) || drinkChoice < 1 || drinkChoice > drinkList.Count)
                {
                    Console.Write("Please enter again: ");
                }

                Drink selectedDrink = drinkList[drinkChoice - 1];
                Console.WriteLine($" {selectedFood.FoodName} - {selectedFood.PriceFood} and {selectedDrink.DrinkName} - {selectedDrink.PriceDrink}");
                Console.WriteLine($" {selectedFood.PriceFood + selectedDrink.PriceDrink}");
            }
            else
            {
                Console.WriteLine($" {selectedFood.FoodName} - {selectedFood.PriceFood}");
                Console.WriteLine($" {selectedFood.PriceFood}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Thank You");
            Console.ReadKey();
        }
    }
}
