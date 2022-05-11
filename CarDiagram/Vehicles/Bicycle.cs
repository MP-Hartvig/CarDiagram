using CarDiagram.Interfaces;
using CarDiagram.WheelAndTire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagram.Vehicles
{
    class Bicycle : IBreakable
    {
        private string registrationNumber;
        private Wheel[] wheels;

        public Bicycle(int numberOfWheels) { }

        public void Break() { }
    }
}
