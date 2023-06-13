using System;

namespace FarmingFeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheep testSheep = new Sheep("lan", 1);

            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);
            testSheep.AddDailyConsumption(300);

            Console.WriteLine(testSheep.SheepInfo(1.03f));

 

        }
    }
}
