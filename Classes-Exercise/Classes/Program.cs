namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();

            firstCar.make = "Lexus";
            firstCar.model = "ES";
            firstCar.year = 2025;


            Console.WriteLine(firstCar.year + " " + firstCar.make + " " + firstCar.model);

        }
    }
}
