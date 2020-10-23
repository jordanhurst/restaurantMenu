using System;
using System.Collections.Generic;

namespace restaurantMenu
{
    public class Menu
    {
        private List<MenuItem> appetizers = new List<MenuItem>();
        private List<MenuItem> mains = new List<MenuItem>();
        private List<MenuItem> desserts = new List<MenuItem>();
        public List<MenuItem>[] fullMenu = new List<MenuItem>[3];
        private string lineDivider = "===============================";
        
        public Menu()
        {
            this.fullMenu[0] = appetizers;
            this.fullMenu[1] = mains;
            this.fullMenu[2] = desserts;
        }

        public void AddMenuItem(MenuItem item)
        {
            if (item.Category == "appetizer")
            {
                appetizers.Add(item);
            } else if (item.Category == "main")
            {
                mains.Add(item);
            }else if (item.Category == "dessert")
            {
                desserts.Add(item);
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Appetizers\n" + lineDivider);
            foreach (MenuItem item in appetizers)
            {
                string isItNew = "";
                if ((DateTime.Now - item.dateAdded).TotalDays < 7)
                {
                    isItNew = "recently added!";
                }
                string itemString = item.Name + " -  $" + item.Cost.ToString() + " -  " + isItNew + "\n" + item.Description + "\n\n";
                Console.WriteLine(itemString);
            }
            Console.WriteLine("\n\n" + lineDivider + "\nMain Entrees\n" + lineDivider);
            foreach (MenuItem item in mains)
            {
                string isItNew = "";
                if ((DateTime.Now - item.dateAdded).TotalDays < 7)
                {
                    isItNew = "recently added!";
                }
                string itemString = item.Name + " -  $" + item.Cost.ToString() + " -  " + isItNew + "\n" + item.Description + "\n\n";
                Console.WriteLine(itemString);
            }
            Console.WriteLine("\n\n" + lineDivider + "\nDesserts\n" + lineDivider);
            foreach (MenuItem item in desserts)
            {
                string isItNew = "";
                if ((DateTime.Now - item.dateAdded).TotalDays < 7)
                {
                    isItNew = "recently added!";
                }
                string itemString = item.Name + " -  $" + item.Cost.ToString() + " -  " + isItNew + "\n" + item.Description + "\n\n";
                Console.WriteLine(itemString);
            }

        }
    }
}
