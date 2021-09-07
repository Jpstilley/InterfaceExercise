using System;
namespace InterfaceExercise
{
    public class Motorcycle: IVehicle, ICompany
    {
        public int Wheels { get; set; }
        public string EngineType { get; set; }
        public string ExhaustType { get; set; }
        public string FrameMaterial { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public Motorcycle()
        {

        }

        public void PrintVehcileInfo()
        {
            Console.WriteLine($"A {Name} {Model} is a {RemoveFirstPart()}.\nIt has a {EngineType} engine.\nIt has a {ExhaustType} exhaust and its frame is made of {FrameMaterial}.\n\n");
        }

        public string RemoveFirstPart()
        {
            return GetType().ToString().Remove(0, 18);
        }

        public void HonkHorn()
        {
            Console.WriteLine("toot toot");
        }

        public void Drive()
        {
            Console.WriteLine($"\nBuilding a {RemoveFirstPart()}");
        }
    }
}
