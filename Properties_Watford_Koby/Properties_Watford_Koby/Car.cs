using System;

namespace Properties_Watford_Koby
{
    public class Car
    {
        // Automatic property for 'Make' with getter and setter.
        // The compiler will automatically create a backing field.
        public string Make { get; set; }

        // Automatic property for 'Model' with getter and setter.
        // Like 'Make', the compiler will handle the backing field automatically.
        public string Model { get; set; }
    }
}
