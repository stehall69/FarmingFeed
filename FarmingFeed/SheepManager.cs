using System;
using System.Collections.Generic;
using System.Text;

namespace FarmingFeed
{
    class SheepManager
    {
        //Attributes
        private string sheepID;
        private List<string> sheepBreeds = new List<string>() { "Arapawa", "Perendale", "Romney", "coopworth" };
        private float feedCost;
        private float avgHealthyFeedConsumed = 0.5f;
        private int sheepNum;
        //Constructor - constructs an object of this class
        public SheepManager()
        {

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
        public bool CheckWeight()
        {
            return true;
        }

        //Generates a ID for each sheep
        public string GenerateID()
        {
            return "";
        }

        //Adds breed not specified on the list that the user farms
        public void AddBreed()
        {

        }

        //Calculates cost of food per year consumed by sheep 
        public float CalculateYearlyCost()
        {
            return 1;
        }

        //Returns a string collating all the values stored in the private variables
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
