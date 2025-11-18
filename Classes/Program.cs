namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car();
            a.Make = "Hyundai";
            a.Model = "Sonata";
            a.Year = 2023;
            Console.WriteLine($"This {a.Make} {a.Model} is made in {a.Year}");
        }
    }

    
}
