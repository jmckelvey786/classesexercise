using System;

namespace ClassesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car!");
            Car car1 = new Car();
            car1.Year = 2011;
            car1.Make = "Ford";
            car1.Model = "Fiesta";

            Console.WriteLine(car1.Year);
            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Model);
        }
    }
}
