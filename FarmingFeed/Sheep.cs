using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmingFeed
{
    class Sheep
    {
        //Attributes and Fields
        private string breed;
        private List<float> weeklyFeedConsumed = new List<float>();
        private string sheepID = "";
        


        //Constructor - Constructs an object of this Class
        public Sheep(string breed, int sheepCount)
        {
            this.breed = breed;
            this.sheepID = GenerateId(sheepCount);
           
          


        }
        
        // Add a daily consumption to weekly feed consumed
        public void AddDailyConsumption(float DailyConsumption) 
        {
            weeklyFeedConsumed.Add(DailyConsumption);
        }
        
        //Calculates total feed consumed
        public float FeedConsumed( )
        {
            float totalFeedConsumed = 0;

            for (int feedIndex = 0; feedIndex < weeklyFeedConsumed.Count; feedIndex++)
            {
                totalFeedConsumed += weeklyFeedConsumed[feedIndex];

            }
            return totalFeedConsumed / 1000;

        }



        
        //Calculates cost of feed consumed
        public float WeeklyFeedCost(float feedCost)
        {

            float costOfFeedConsumed = FeedConsumed() * feedCost;
            costOfFeedConsumed = (float)Math.Round((decimal)costOfFeedConsumed, 2);
            return costOfFeedConsumed;
        }

        //Create Id for Each Animal
        public string GenerateId(int sheepCount)
        {
          
            return sheepCount + breed.Substring(0, 2).ToLower(); 
        }

        //Summarises data for a sheep and displays it 
        public string SheepInfo(float feedCost)
        {
            String sheepInfo = $"Breed : {breed}\nID : {sheepID}\n\n============Feed Info============\n\nWeekly Feed: {FeedConsumed()}kg \nCost of Feed ${WeeklyFeedCost(feedCost)}\n ";
            
            



            return sheepInfo;
        }
        
        // returns a string collating all the values stored in the private variables
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
