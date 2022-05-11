using CarDiagram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagram.Cars
{
    class Volvo : IBreakable, IGasolineEngine
    {
        private float capacity;

        public Volvo(float capacity)
        {

        }

        public void Inject() { }
        public void Start() { }
        public void Break() { }
        public void TurnOff() { }
    }
}
