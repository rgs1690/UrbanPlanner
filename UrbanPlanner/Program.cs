using System;
using UrbanPlanner.Buildings;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("512 8th Avenue");

            building1.Width = 1000.35;
            building1.Depth = 5000.45;
            building1.Stories = 7;

            building1.Construct();
            building1.Purchase("Starbucks");
            building1.GetDetails();
        }
    }
}
