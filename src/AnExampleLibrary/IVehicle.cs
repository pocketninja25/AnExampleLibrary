namespace AnExampleLibrary
{

    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        int Year { get; }

        void Start();
        void Stop();
    }
}
