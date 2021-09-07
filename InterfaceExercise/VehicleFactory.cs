using System;
namespace InterfaceExercise
{
    public static class VehicleFactory
    {

        public static IVehicle GetVehicle()
        {
            Console.WriteLine($"Welcome to the Vehicle Factory.");
            Console.WriteLine("Please indicate how many wheels you would like on your vehicle");
            Console.WriteLine($"2: Motorcyle\n4: Four Wheel Vehicle\n18: Big Rig");
            var userInput = Console.ReadLine();
            int correctAnswer;
            int.TryParse(userInput, out correctAnswer);
            switch (correctAnswer)
            {
                case 4:
                    return FourWheelVehicle();
                case 2:
                    return new Motorcycle();
                case 18:
                    return new BigRig();
                default:
                    Console.WriteLine($"\nThat is not a valid response.\nPlease try again.\n");
                    GetVehicle();
                    return new Car();
            }
        }

        public static IVehicle FourWheelVehicle()
        {
            Console.WriteLine($"\nWhat kind of 4 wheel vehicle would you like to create?");
            Console.WriteLine($"1. Car\n2. SUV\n3. Truck");
            var userInput = Console.ReadLine();
            int correctAnswer;
            int.TryParse(userInput, out correctAnswer);
            switch (correctAnswer)
            {
                case 1:
                    return new Car();
                case 2:
                    return new SUV();
                case 3:
                    return new Truck();
                default:
                    Console.WriteLine($"\nThat is not a valid response.\nPlease try again.\n");
                    FourWheelVehicle();
                    return new Car();
            }
        }
    }
}
