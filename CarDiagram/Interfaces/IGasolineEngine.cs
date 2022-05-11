using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagram.Interfaces
{
    public interface IGasolineEngine : IEngine
    {
        void Inject();
    }
}
