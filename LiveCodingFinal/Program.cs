using System;

namespace LiveCodingFinal
{
    class Program
    {
        static void Main(string weather, string temperature)
        {
            double standardVisitors = 250;
            double additionalVisitors = 0;
            double totalVisitors = 0;
            double candyNeeded = 0;

            if (weather == "Clear")
            {
                additionalVisitors += .1 * standardVisitors;
            }
            else if (weather == "Cloudy")
            { 
                additionalVisitors += 0 * standardVisitors; 
            }
            else if (weather == "Raining")
            {
                additionalVisitors += -.25 * standardVisitors;
            }
            else if (weather == "Full Moon")
            {
                additionalVisitors += .25 * standardVisitors;
            }

            if (temperature == "40s")
            {
                additionalVisitors += -.05 * standardVisitors;
            }
            else if (temperature == "50s")
            {
                additionalVisitors += 0 * standardVisitors;
            }
            else if (temperature == "60s")
            {
                additionalVisitors += .05 * standardVisitors;
            }
            else if (temperature == "70s")
            {
                additionalVisitors += .20 * standardVisitors;
            }

            totalVisitors = standardVisitors + additionalVisitors;
            candyNeeded = 3 * totalVisitors;
            Console.WriteLine(candyNeeded);
        }
    }
}
