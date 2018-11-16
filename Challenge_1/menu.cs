using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Menu
    {
        public string Name { get; set; }
        public int MealNumber { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Ingredients { get; set; }

        public Menu(string name, int mealNumber, string description, int price, string ingredients)
        {
            Name = name;
            MealNumber = mealNumber;
            Description = description;
            Price = price;
            Ingredients = ingredients;
        }

        public Menu()
        {

        }
    }
}
