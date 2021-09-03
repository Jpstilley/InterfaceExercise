using System;
namespace InterfaceExercise
{
    public class SUV : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public bool HasBackseatVideoScreen { get; set; }

        public SUV()
        {
        }

        public override void PrintVehcileInfo()
        {
            Console.WriteLine($"A {Name} {Model} is a {RemoveFirstPart()}.\nIt has a {NumberOfSeats} seats and {WriteVideoScreen()}.\nIt has a {EngineType} engine with a {ExhaustType} exhaust and its frame is made of {FrameMaterial}.\n\n");
        }

        public string WriteVideoScreen()
        {
            return (HasBackseatVideoScreen) ? "has a videoscreen in the rear for the passengers to enjoy" : "has no videoscreen in the rear of the vehicle";
        }

        
    }
}
