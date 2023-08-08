using System;

namespace FarmingFeed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sheepBreeds = new List<string>() { "Arapawa ", "Perendale ", "Romney ", "coopworth " };
            
            Console.WriteLine("------ testing Sheep Class ------");
            Sheep testSheep = new Sheep("Arapawa", 1);


            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);

            Console.WriteLine(testSheep.SheepInfo(1.03f));

            Console.WriteLine("------ Testing Sheep Manager Class ------");
            
            SheepManager testSM = new SheepManager();

            testSM.AddSheep("Arapawa");
            
            testSM.AddConsumption("1ar", 2100f);
            
            Console.WriteLine(testSM.SheepInfoById("1ar"));
            
            Console.WriteLine(testSM.CheckWeight(2100f));

            testSM.AddBreed("bill");
            Console.WriteLine(sheepBreeds);
 

        }
    }
}
