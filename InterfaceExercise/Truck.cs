using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool ExtendedCab { get; set; }
        public bool HasToolBox { get; set; }

        public int Wheels { get; set; }
        public string EngineType { get; set; }
        public string ExhaustType { get; set; }
        public string FrameMaterial { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public Truck()
        {
        }

        public void PrintVehcileInfo()
        {
            Console.WriteLine($"A {Name} {Model} is a {RemoveFirstPart()}.\nIt {WriteHasToolBox()}{WriteExtendedCab()}.\nIt has a {EngineType} engine with a {ExhaustType} exhaust and its frame is made of {FrameMaterial}.\n\n");
        }

        public string WriteExtendedCab()
        {
            return (ExtendedCab) ? "and has an extended cab for more seating" : "";
        }

        public string WriteHasToolBox()
        {
            return (HasToolBox) ? "has a toolbox" : "doesn't have a toolbox";
        }

        public string RemoveFirstPart()
        {
            return GetType().ToString().Remove(0, 18);
        }

        public void HonkHorn()
        {
            Console.WriteLine("Awooga");
        }

        public void Drive()
        {
            Console.WriteLine($"\nBuilding a {RemoveFirstPart()}");
        }


    }
}
