using System;

namespace Properties_Watford_Koby
{
    class Program
    {
        // Main method - the entry point for the application.
        static void Main(string[] args)
        {
            // Create the first Car object.
            // The car object 'car1' has the 'Make' set to 'Ford' and 'Model' set to 'Mustang'.
            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Mustang";

            // Create the second Car object.
            // This car object 'car2' has the 'Make' set to 'Chevy' and 'Model' set to 'Camero'.
            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            // Create the third Car object.
            // 'car3' has no 'Make' or 'Model' assigned, meaning these properties will be empty strings by default.
            Car car3 = new Car();

            // Print the details of the first car object (car1).
            // The result will show 'Make: Ford' and 'Model: Mustang' because these properties were set.
            Console.WriteLine($"Make: {car1.Make}, Model: {car1.Model}");

            // Print the details of the second car object (car2).
            // The result will show 'Make: Chevy' and 'Model: Camero' because these properties were set.
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            // Print the details of the third car object (car3).
            // Since 'Make' and 'Model' were not set for car3, they will be empty strings by default.
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}
