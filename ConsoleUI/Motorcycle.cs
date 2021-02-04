using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        { }
        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine($" Motorcycle is in Drive");
        }
        public override void DriveVritual()
        {
            Console.WriteLine($"{ GetType().Name} {GetType().BaseType.Name}");
        }
    }
    
}
