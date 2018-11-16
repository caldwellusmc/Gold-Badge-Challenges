using System;
using System.Collections.Generic;

namespace Challenge_2
{
    public class ProgramUI
    {
        ClaimRepository claimrepo = new ClaimRepository();

        public void Run()
        {
            RunClaim();
        }

        private void RunClaim()
        {
            Claim house = new Claim(1, "house", "fire", 333.22m, "07/05/12", "07/06/12", true);
            Claim boat = new Claim(2, "boat", "fire", 342.34m, "09/03/12", "10/05/12", false);
            claimrepo.AddClaimToQueue(house);
            claimrepo.AddClaimToQueue(boat);

            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("Choose and option:" +
                    "\n1. View all Claims." +
                    "\n2. Take care of your next claim." +
                    "\n3. Enter a new claim." +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        ViewClaim();
                        break;
                    case 2:
                        TakeNextClaim();
                        break;
                    case 3:
                        EnterNewClaim();
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

        private void EnterNewClaim()
        {
            Claim newClaim = new Claim();
            Console.WriteLine("Enter claim ID");
            newClaim.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter claim type");
            newClaim.ClaimType = Console.ReadLine();

            Console.WriteLine("Enter a Description");
            newClaim.ClaimDescription = Console.ReadLine();

            Console.WriteLine("Enter claim amount");
            newClaim.ClaimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date of the incident");
            newClaim.DateOfIncident = Console.ReadLine();

            Console.WriteLine("Enter the date of the claim");
            newClaim.DateOfClaim = Console.ReadLine();

            newClaim.IsValid = claimrepo.GetBoolan(newClaim);

            claimrepo.AddClaimToQueue(newClaim);
        }

        private void ViewClaim()
        {
            Queue<Claim> claimList = claimrepo.ViewClaims();
            Console.WriteLine("ID \tType \tDescription\tAmount\tIncident Date\tClaim Date");
            foreach (Claim claim in claimList)
            {
                Console.WriteLine($"{claim.ClaimID} \t{claim.ClaimType} \t{claim.ClaimDescription} \t{claim.ClaimAmount} \t{claim.DateOfIncident} \t{claim.DateOfClaim}");
            }
            Console.ReadLine();
        }

        private void TakeNextClaim()
        {
            Queue<Claim> claimList = claimrepo.ViewClaims();
            Console.WriteLine("Do you want to view the next claim? (y/n)");

            string input = Console.ReadLine();
            if(input == "y")
            {
                Claim nextClaim = claimList.Peek();
                Console.WriteLine($"Here's the next claim ID {nextClaim.ClaimID}");
                Console.WriteLine();
                Console.WriteLine("Do you want to process this claim? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    nextClaim = claimList.Dequeue();
                }
            }
        }
    }
}
