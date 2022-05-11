using CarDiagram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagram.Cars
{
    class Toyota : IBreakable, IGasolineEngine
    {
        private float capacity;

        public Toyota(float capacity) { }

        public void Inject() { }
        public void Start() { }
        public void Break() { }
        public void TurnOff() { }
    }
}
