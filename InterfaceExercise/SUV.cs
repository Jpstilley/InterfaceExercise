using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int NumberOfSeats { get; set; }
        public bool HasBackseatVideoScreen { get; set; }

        public int Wheels { get; set; }
        public string EngineType { get; set; }
        public string ExhaustType { get; set; }
        public string FrameMaterial { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public SUV()
        {
        }

        public  void PrintVehcileInfo()
        {
            Console.WriteLine($"A {Name} {Model} is an {RemoveFirstPart()}.\nIt has a {NumberOfSeats} seats and {WriteVideoScreen()}.\nIt has a {EngineType} engine with a {ExhaustType} exhaust and its frame is made of {FrameMaterial}.\n\n");
        }

        public string WriteVideoScreen()
        {
            return (HasBackseatVideoScreen) ? "has a videoscreen in the rear for the passengers to enjoy" : "has no videoscreen in the rear of the vehicle";
        }

        public string RemoveFirstPart()
        {
            return GetType().ToString().Remove(0, 18);
        }

        public void HonkHorn()
        {
            Console.WriteLine("HONK HONK");
        }

        public void Drive()
        {
            Console.WriteLine($"\nBuilding a {RemoveFirstPart()}");
        }

        internal void CanISeeIt()
        {
            Console.WriteLine("Yes I Can!");
        }
    }
}
