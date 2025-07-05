using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {

        public bool HasSideCart { get; set; }

        public override void DriveAbstrack()
        {
            Console.WriteLine("Motorcylce has rear wheel drive"); 
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcylce is comfortable.");
        }
    }
}
