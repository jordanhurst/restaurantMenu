using System;

namespace restaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Console.WriteLine("Welcome to Puzzles\nWould you like to:\nAdd something to the menu? (press 1)\n---or---\nSee our menu? (press 2)");
            string input = Console.ReadLine();

            if(input == "1")
            {
                bool moreAdditions = false;

                do
                {

                    double costInputNum = 0.0;
                    string typeInput = "";

                    Console.WriteLine("Please enter a new menu item:\nName:");
                    string nameInput = Console.ReadLine();

                    do
                    {
                        Console.WriteLine("Cost: ");
                        string costInput = Console.ReadLine();
                        try
                        {
                            costInputNum = Convert.ToDouble(costInput);
                            Console.WriteLine("cost conversion worked.");
                        }
                        catch
                        {
                            Console.WriteLine("conversion didn't work");
                        }

                        if (costInputNum <= 0)
                        {
                            Console.WriteLine("Please enter a valid value for the cost.");
                        }
                    } while (costInputNum <= 0.0);

                    do
                    {
                        Console.WriteLine("Is it an appetizer, entree, or dessert?\nAppetizer (enter 1)\nEntree (enter 2)\nDessert (enter 3)");
                        typeInput = Console.ReadLine();
                        if (typeInput == "1")
                        {
                            typeInput = "appetizer";
                        }
                        else if (typeInput == "2")
                        {
                            typeInput = "main";
                        }
                        else if (typeInput == "3")
                        {
                            typeInput = "dessert";
                        }
                        else
                        {
                            Console.WriteLine("Please choose 1, 2, or 3.");
                            typeInput = "";
                        }
                    } while (typeInput == "");

                    Console.WriteLine("Enter a brief description of the dish: ");
                    string descriptionInput = Console.ReadLine();

                    MenuItem newMenuAddition = new MenuItem(nameInput, costInputNum, typeInput, descriptionInput);
                    menu.AddMenuItem(newMenuAddition);

                    Console.WriteLine("\n\nYour menu item has been added. Would you like to add another? y/n");
                    string additionInput = Console.ReadLine();
                    if (additionInput == "y")
                    {
                        moreAdditions = true;
                    } else
                    {
                        Console.WriteLine("Would you like to view the menu? y/n");
                        string viewMenuInput = Console.ReadLine();
                        if (viewMenuInput == "y")
                        {
                            menu.DisplayMenu();
                        }
                    }
                } while (moreAdditions);

            } else if(input == "2")
            {
                menu.DisplayMenu();
            }
        }
    }
}
