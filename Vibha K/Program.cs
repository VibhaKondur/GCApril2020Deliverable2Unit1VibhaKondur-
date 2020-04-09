using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vibha_K
{
    class Program
    {
        static void Main(string[] args)
        {
            int debug = 0;
            string vacationType = "";
            string Destination = "";
            string TravelSuggestion = "";
            int GroupSize = 0;
            int vacationCheck = 0;

            while (debug != 1)
            {
                Console.WriteLine("What type of vacation do you want to go on - Musical, Tropical, or Adventurous?");
                vacationType = Console.ReadLine();

                
                while (vacationCheck != 1)
                {
                    if (vacationType == "Musical")
                    {
                        Destination = "New Orleans";
                        vacationCheck = 1;
                    }
                    else if (vacationType == "musical")
                    {
                        Destination = "Beach Vacation in Mexico";
                        vacationCheck = 1;
                    }
                    else if (vacationType == "Tropical")
                    {
                        Destination = "Beach Vacation in Mexico";
                        vacationCheck = 1;
                    }
                    else if (vacationType == "tropical")
                    {
                        Destination = "Beach Vacation in Mexico";
                        vacationCheck = 1;
                    }
                    else if (vacationType == "Adventurous")
                    {
                        Destination = "Whitewater Rafting the Grand Canyon";
                        vacationCheck = 1;
                    }
                    else if (vacationType == "adventurous")
                    {
                        Destination = "Whitewater Rafting the Grand Canyon";
                        vacationCheck = 1;
                    }

                    if (vacationCheck != 1)
                    {
                        Console.WriteLine("Sorry. I didn't catch the vacation you're going on...");
                        Console.Write("Can you please retype your vacation?");
                        vacationType = Console.ReadLine();
                    }                  
                }

                Console.WriteLine("How many people are you traveling with?");
                GroupSize = Convert.ToInt32(Console.ReadLine());
                if (GroupSize >= 1 && GroupSize <= 2)
                {
                    TravelSuggestion = "First Class Trip";
                }
                else if (GroupSize >= 3 && GroupSize <= 5)
                {
                    TravelSuggestion = "Helicopter Flight";
                }
                else if (GroupSize >= 6)
                {
                    TravelSuggestion = "Charter Flight";
                }

                //Console.WriteLine("Since you're a group of" + GroupSize + "going on a" + vacationType + "vacation, you should take a" + TravelSuggestion + "to" + Destination);
                Console.WriteLine("Since you're a group of {0} going on a {1} vacation, you should take a {2} to {3}", GroupSize, vacationType, TravelSuggestion, Destination);
                Console.WriteLine("Program is finished. Press 0 to continue or press 1 to end the program.");
                debug = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}
