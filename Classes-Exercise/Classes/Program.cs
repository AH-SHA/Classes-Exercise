namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            {
                firstCar.Make = "Lexus";
                firstCar.Model = "ES";
                firstCar.Year = 2025;
            }

            Console.WriteLine(firstCar.Year + " " + firstCar.Make + " " + firstCar.Model);

        }
    }
}
