using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"This {Year} {Make} {Model} is a car and it's driving.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {Year} {Make} {Model} car is driving.");
        }
    }
}
