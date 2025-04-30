namespace AnExampleLibrary
{
    public class Plane : IVehicle
    {
        public Plane(string make, string model, int year, int numberOfEngines)
        {
            Make = make;
            Model = model;
            Year = year;
            NumberOfEngines = numberOfEngines;
        }

        public int NumberOfEngines { get; }

        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public void Start()
        {
            // Example logic for starting a plane
            System.Diagnostics.Debug.WriteLine("Plane started.");
        }

        public void Stop()
        {
            // Example logic for stopping a plane
            System.Diagnostics.Debug.WriteLine("Plane stopped.");
        }
    }
}
