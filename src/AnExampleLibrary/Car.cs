namespace AnExampleLibrary
{
    public class Car : IVehicle
    {
        public int NumberOfDoors { get; }

        public Car(string make, string model, int year, int numberOfDoors)
        {
            Make = make;
            Model = model;
            Year = year;
            NumberOfDoors = numberOfDoors;
        }

        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public void Start()
        {
            // Example logic for starting a car
            System.Diagnostics.Debug.WriteLine("Car started.");
        }

        public void Stop()
        {
            // Example logic for stopping a car
            System.Diagnostics.Debug.WriteLine("Car stopped.");
        }
    }
}
