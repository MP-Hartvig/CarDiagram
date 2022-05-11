using CarDiagram.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagram.Interfaces
{
    class Factory
    {
        List<Vehicle> vehicles;

        private Factory() { }

        public static void Instance() { }

        public Vehicle Create(int type) 
        {
            string color = "Green";
            Vehicle vehicle = new Car(color);
            return vehicle;
        }
    }
}
