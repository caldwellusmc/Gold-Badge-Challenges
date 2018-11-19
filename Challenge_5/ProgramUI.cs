using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class ProgramUI
    {
        CustomerRepository customerrepo = new CustomerRepository();

        public void Run()
        {
            RunMenu();
        }


        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Select from the following options:" +
                    "\n1. Create" +
                    "\n2. View" +
                    "\n3. Update" +
                    "\n4. Delete" +
                    "\n5. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        View();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("Thank You");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Not an option");
                        Console.ReadLine();
                        break;
                }
            }
        }
        private void Create()
        {
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter the First Name.");
            newCustomer.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name.");
            newCustomer.LastName = Console.ReadLine();

            Console.WriteLine("Is this a past, present, or potential customer?");
            string input = Console.ReadLine();
        }
        private void View()
        {

        }
        private void Update()
        {

        }
        private void Delete()
        {

        }
    }
}
