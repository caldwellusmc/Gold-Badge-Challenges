using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepository
    {
        List<Outing> _listOfOutings = new List<Outing>();
        
        public void AddOutingsToList(Outing Outings)
        {
            _listOfOutings.Add(Outings);
        }

        public List<Outing> ViewList()
        {
            return _listOfOutings;
        }

        public decimal AddCostOfOutings()
        {
            decimal total = 0;
            foreach (Outing outing in _listOfOutings)
            {
                total += outing.CostOfEvent;
            }
            return total;
        }

        public decimal AddCostByEvent(string type)
        {
            decimal typeTotal = 0;
            foreach (Outing o in _listOfOutings)
            {
                if (type == o.EventType)
                {
                    typeTotal += o.CostOfEvent;
                }
            }
               return typeTotal;
        }
    }
}
