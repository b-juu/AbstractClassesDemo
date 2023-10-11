using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine($"This {Year} {Make} {Model} is a motorcycle and it's driving.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {Year} {Make} {Model} motorcycle is driving .");
        }
    }
}
