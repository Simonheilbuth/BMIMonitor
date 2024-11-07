

namespace BMIMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Weight = 75,
                Height = 1.75
            };

            Console.WriteLine($"BMI for {person.FirstName} {person.LastName}: {person.BMI:F2}");
            Console.ReadKey();
        }
    }
}