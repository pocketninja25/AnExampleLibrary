namespace AnExampleLibrary
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, Job? job = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Job = job;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public Job? Job { get; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {Age}, Job: {Job?.Title ?? "Unemployed"}";
        }
    }
}
