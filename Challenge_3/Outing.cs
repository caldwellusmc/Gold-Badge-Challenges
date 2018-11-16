using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class Outing
    {
        public string EventType { get; set; }
        public int NumberOfPeople { get; set; }
        public string DateOfOuting { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostOfEvent { get; set; }

        public Outing()
        {

        }

        public Outing(string eventType, int numberOfPeople, string dateOfOuting, decimal costPerPerson, decimal costOfEvent)
        {
            EventType = eventType;
            NumberOfPeople = numberOfPeople;
            DateOfOuting = dateOfOuting;
            CostPerPerson = costPerPerson;
            CostOfEvent = costOfEvent;
        }
    }
}
