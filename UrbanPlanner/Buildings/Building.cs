using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.Buildings
{
    class Building
    {
        // FIELDS its common to have fields then properties then methods
        // Fields are automatically private, its preference whether to put the private keyword or not
        
        private string _designer = "Grace"; // can also make it a constructor 
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        // PROPERTIES 

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return
                  Width * Depth * (3 * Stories); // if you have a property that has custom code and its only one line you can format it like this
                // get => Width * dEPTH * (3* sTORIES)
            }
        }
        // METHODS
        // CONSTRUCTOR is a method ran whenever a new instance of class is made. Has the same name as class
        // overloading is when you have the same name on multiple methods but each one has a different signature. signature = Name(parameters) -- has different parameters
        public Building(string address)
        {
            _address = address;  // field name has to be first
        }
        
        
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            _owner = name; 
        }
        
        public void GetDetails()
        {
            Console.WriteLine($@"
 {_address}----------
 Designed by {_designer} 
 Constructed on {_dateConstructed} 
 Owned by {_owner} 
 {Volume} cubic meters of space"); 
               
        }

        

    
    }
}
