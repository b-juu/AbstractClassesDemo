using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; } = "GenericYear";
        public string Make { get; set; } = "GenericMake";
        public string Model { get; set; } = "GenericModel";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {Year} {Make} {Model} is driving .");
        }
    }
}
