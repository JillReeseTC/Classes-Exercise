namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //New instance of the Car class
            Car myCar = new Car();

            myCar.Make = "Chevrolet";
            myCar.Model = "Impala";
            myCar.Year = 1987;

            Console.WriteLine($"Make is {myCar.Make}, Model is {myCar.Model}, Year is {myCar.Year}.");
        }
    }
}

                