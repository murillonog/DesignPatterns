using Builder.Components;

namespace Builder.Products
{
    class Vehicle
    {
        private int seats;
        private Airbag airbag;
        private Engine engine;
        private VehicleType vehicleType;
        private Transmission transmission;

        public int Seats { get => seats; set => seats = value; }
        public Airbag Airbag { get => airbag; set => airbag = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public VehicleType VehicleType { get => vehicleType; set => vehicleType = value; }
        public Transmission Transmission { get => transmission; set => transmission = value; }
    }
}
