using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagram.Vehicles
{
    public abstract class Vehicle
    {
        protected abstract void TurnLeft(float degrees);

        protected void MoveForward() { }
    }
}
