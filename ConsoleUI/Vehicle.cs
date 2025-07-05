using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2000s"; 
        public string Make { get; set; } = "American";
        public string Model { get; set; } = "Racer";

        public abstract void DriveAbstrack(); 

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("Lets Ride!"); 
        }

            
    }
}
