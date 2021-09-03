using System;
namespace InterfaceExercise
{
    public class Truck : Vehicle
    {
        public bool ExtendedCab { get; set; }
        public bool HasToolBox { get; set; }

        public Truck()
        {
        }

        public override void PrintVehcileInfo()
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

        
    }
}
