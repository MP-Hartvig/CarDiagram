using CarDiagram.Parts;
using CarDiagram.Interfaces;
using CarDiagram.WheelAndTire;
using static CarDiagram.Parts.Gearbox;

namespace CarDiagram.Vehicles
{
    class Car : Vehicle
    {
        private string registrationNumber;
        private string registrationYear;
        private IEngine engine;
        private Wheel[] wheels;
        private Gearbox gearBox;

        protected override void TurnLeft(float degrees) { }

        internal Car(IGasolineEngine engine) 
        {
            this.engine = engine;
            gearBox = new Gearbox();
        }

        public Car(string color) { }
        public Car(string color, float size) { }
    }
}
