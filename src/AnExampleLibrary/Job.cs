namespace AnExampleLibrary
{
    public class Job
    {
        public string Title { get; }
        public decimal Salary { get; }

        public Job(string title, decimal salary)
        {
            Title = title;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Title} - Salary: {Salary:C}";
        }
    }
}
