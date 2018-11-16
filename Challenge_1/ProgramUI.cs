using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class ProgramUI
    {
        MenuRepository menuRepo = new MenuRepository();
        private List<Menu> itemList;

        public void Run()
        {
            itemList = menuRepo.ViewList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("What would you like to do?" +
                    "\n1. Create an item." +
                    "\n2. Delete an item." +
                    "\n3. View menu items." +
                    "\n4. Exit.");

                int input = int.Parse(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        CreateItem();
                        break;
                    case 2:
                        DeleteItem();
                        break;
                    case 3:
                        ViewList();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Good Bye");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Not an option");
                        Console.ReadLine();
                        break;
                }
            }
        }
        private void CreateItem()
        {
            Menu newItem = new Menu();
            Console.WriteLine("What's the item name?");
            newItem.Name = Console.ReadLine();

            Console.WriteLine("\nWhat's the item number?");
            newItem.MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nType a Description.");
            newItem.Description = Console.ReadLine();

            Console.WriteLine("\nWhat's the price?");
            newItem.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("\nList the Ingredients.");
            newItem.Ingredients = Console.ReadLine();

            menuRepo.AddItemsToList(newItem);
        }

        private void DeleteItem()
        {
            Console.WriteLine("What would you like to delete?");
            foreach(Menu item in itemList)
            {
                Console.WriteLine($"{item.MealNumber} {item.Name} {item.Description} {item.Ingredients} {item.Price}");
            }
            Console.WriteLine("Type the name");
            var deleteitem = Console.ReadLine();

            foreach(Menu item in itemList)
            {
                if(deleteitem == item.Name)
                {
                    menuRepo.DeleteItem(item);
                    break;
                }
            }
        }

        private void ViewList()
        {
            List<Menu> itemList = menuRepo.ViewList();
            foreach (Menu item in itemList)
            {
                Console.WriteLine($"{item.MealNumber} {item.Name} {item.Description} {item.Ingredients} {item.Price}");
            }
            Console.ReadLine();
        }
    }
}
