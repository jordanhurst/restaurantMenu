using System;
namespace restaurantMenu
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public double Cost { get; private set; }
        public string Category
        {
            get; private set
            {
                if ((value != "dessert") || (value != "main") || (value != "appetizer"))
                {
                    throw new ArgumentException("category must be 'appetizer' 'main' or 'dessert'");
                };
            }
        }
        public string Description { get; private set; }
        public DateTime currentDate = DateTime.Now;
        internal DateTime dateAdded;

        public MenuItem(string name, double cost, string category, string description)
        {
            Name = name;
            Cost = cost;
            Category = category;
            Description = description;
            DateTime dateAdded = currentDate;
        }
    }
}
