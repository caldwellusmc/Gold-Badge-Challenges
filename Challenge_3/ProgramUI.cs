using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class ProgramUI
    {
        OutingRepository outingrepo = new OutingRepository();

        public void Run()
        {
            RunMenu();
        }


        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose and option:" +
                    "\n1. View List of outings." +
                    "\n2. Add an outing." +
                    "\n3. View total cost of outings." +
                    "\n4. View cost of outings by event." +
                    "\n5. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ViewList();
                        break;
                    case 2:
                        AddOutings();
                        break;
                    case 3:
                        Console.WriteLine($"The total cost of all outings is {outingrepo.AddCostOfOutings()}");
                        break;
                    case 4:
                        AddCostByEvent();
                        break;
                    case 5:
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

        private void ViewList()
        {
            List<Outing> outingList = outingrepo.ViewList();
            foreach (Outing outings in outingList)
            {
                Console.WriteLine($"Here's a list of Outings!  {outings.EventType} {outings.DateOfOuting} {outings.NumberOfPeople} {outings.CostPerPerson} {outings.CostOfEvent}");

            }
            Console.ReadLine();
        }

        private void AddOutings()
        {
            Outing newOuting = new Outing();
            Console.WriteLine("What type of event is it?");
            newOuting.EventType = Console.ReadLine();

            Console.WriteLine("How many people will be there?");
            newOuting.NumberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("What's the date of the outing?");
            newOuting.DateOfOuting = Console.ReadLine();

            Console.WriteLine("What is the cost per person?");
            newOuting.CostPerPerson = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What is the cost of the event?");
            newOuting.CostOfEvent = decimal.Parse(Console.ReadLine());

            outingrepo.AddOutingsToList(newOuting);
        }

        private void AddCostByEvent()
        {
            List<Outing> outingList = outingrepo.ViewList();

            Console.WriteLine("Which type of event cost would you like see?");
            string outing = Console.ReadLine();

            decimal eventCost = 0m;

            foreach (Outing o in outingList)
            {
                if( outing == o.EventType)
                {
                    eventCost += o.CostOfEvent;
                }
            }

            Console.WriteLine($"The total cost of the event type you selected is {eventCost}");
            Console.ReadLine();
        }
    }
}
