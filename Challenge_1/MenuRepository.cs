using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuRepository
    {
        List<Menu> _listOfItems = new List<Menu>();

        public void AddItemsToList(Menu Items)
        {
            _listOfItems.Add(Items);
        }

        public void DeleteItem(Menu Items)
        {
            _listOfItems.Remove(Items);
        }

        public List<Menu> ViewList()
        {
            return _listOfItems;
        }
    }
}
