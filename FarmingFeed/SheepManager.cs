using System;
using System.Collections.Generic;
using System.Text;

namespace FarmingFeed
{
    class SheepManager
    {
        //Attributes
        private List<Sheep> sheep = new List<Sheep>();
        private List<string> sheepBreeds = new List<string>() { "Arapawa ", "Perendale ", "Romney ", "coopworth " };
        private float feedCost = 1.03f;
        private float avgHealthyFeedConsumed = 0.5f;
        private int sheepCount;
        //Constructor - constructs an object of this class
        public SheepManager()
        {

        }
        public void AddSheep(string breed)
        {
            sheep.Add(new Sheep(breed, sheep.Count + 1));
        }
        public void AddConsumption(string Id, float consumption)
        {
            sheep[FindSheepIndex(Id)].AddDailyConsumption(consumption);
        }
        
        //Finds one sheep that equals ID
        public int FindSheepIndex(string Id)
        {
            foreach (var oneSheep in sheep)
            {
                if ( oneSheep.GetSheepId().Equals(Id))
                {
                    return sheep.IndexOf(oneSheep);
                }

            }
            return -1;
        }
        
        //Calculates weekly feed consumed from all sheep
        public float CalculateWeeklyFeedConsumed()
        {
            return 1;
        }

        //Calculates total cost for feed from all feed consumed by sheep
        public float CalculateWeeklyCost()
        {
            return 1;
        }

        //Checks if sheep is over eating or not eating enough feed
        public string CheckWeight(float totalFeedConsumed)
        {
            string weightStatus = "" ;
            
            if ( totalFeedConsumed < 3000  )
            {
                weightStatus = $"Your sheep is under fed by : {2500 - totalFeedConsumed}g";
                return weightStatus;
            }
            else if ( totalFeedConsumed > 4000 )
            {
                weightStatus = $"Your sheep is over-fed by {totalFeedConsumed - 3500}g ";
                return weightStatus;
            }
            else
            {
               return weightStatus = "Your sheep is eating a healthy amount";
            }

           
           
            
        }


        //Adds breed not specified on the list that the user farms
        public void AddBreed(string newBreed)
        {
            sheepBreeds.Add(newBreed);

        }
 
        //Calculates cost of food per year consumed by sheep 
        public float CalculateYearlyCost()
        {
            return 1;
        }
        //Displays sheep info via Id
        public string SheepInfoById(string Id)
        {
            return sheep[FindSheepIndex(Id)].SheepInfo(feedCost);
        }

        //Returns a string collating all the values stored in the private variables
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
