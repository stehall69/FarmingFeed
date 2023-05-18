using System;
using System.Collections.Generic;
using System.Text;

namespace FarmingFeed
{
    class Sheep
    {
        //Attributes and Fields
        private string breed;
        private float totalFeedConsumed;
        private float costOfFeedConsumed;
        private List<float> WeeklyFeedConsumed = new List<float>() { 0,0,0,0,0,0,0};

        //Constructor - Constructs an object of this Class
        public Sheep(string breed, float totalFeedConsumed, float costOfFeedConsumed)
        {
            this.breed = breed;
            this.totalFeedConsumed = 0;
            this.costOfFeedConsumed = 0;


        }
        //Calculates total feed consumed
        public float FeedConsumed()
        {
            for (int feedIndex = 0; feedIndex < 7; feedIndex++)
            {

            }

        }

        //returns the value in the private totalFeedConsumed variable
        public float GetFeed()
        {
            return totalFeedConsumed;
        }

        
        //Calculates cost of feed consumed
        public float WeeklyFeedCost()
        {
            return 1;
        }
        
        //Summarises data for a sheep and displays it 
        public string SheepInfo()
        {
            return "";
        }
        
        // returns a string collating all the values stored in the private variables
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
