using System;
using UrbanPlanner.Buildings;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {    // instantiate- use the 'new' keyword to crate an instance of an onject
            // initialize- give an instance an initial value
            Building building1 = new Building("512 8th Avenue");  

            building1.Width = 1000.35;
            building1.Depth = 5000.45;
            building1.Stories = 7;

            building1.Construct();
            building1.Purchase("Starbucks");
            building1.GetDetails();

            Building building2 = new ("3132 Main St"); // because we stated its a building in the beginning you can just use the new keyword
            building2.Width = 10.11;
            building2.Depth = 50.25;
            building2.Stories = 3;
            
            building2.Construct();
            building2.Purchase("Bob");
            building2.GetDetails();

            Building building3 = new Building("3136 Main St")       // curly braces allows you to not keep typing building3
            {
                Width = 7,
                Depth = 4,
                Stories = 9
            };
            building3.Construct();
            building3.Purchase("Steve");
            building3.GetDetails();

            Building building4 = new Building("444 Zebra  St")
            {
                Width = 17.34,
                Depth = 4.25,
                Stories = 19
            };
            
            building4.Construct();
            building4.Purchase("Seymour");
            building4.GetDetails();
            Building building5 = new Building("221B Baker St")
            {
                Width = 70,
                Depth = 44.55,
                Stories = 7
            };
            
            building5.Construct();
            building5.Purchase("Seymour");
            building5.GetDetails();


            // @ --string verbatim - will take every keystroke literally including new lines (Enter Key)
          
        }
    }
}
