using System;
namespace InterfaceExercise
{
    public class Car : Vehicle  
    {
        public bool IsSuperCar { get; set; }
        public int NumberOfDoors { get; set; }

        public Car()
        {

        }

        public override void PrintVehcileInfo()
        {
            Console.WriteLine($"A {Name} {Model} is a {RemoveFirstPart()}.\nIt {WriteSuperCar()} with a {EngineType} and has {NumberOfDoors} doors.\nIt has a {ExhaustType} exhaust and its frame is made of {FrameMaterial}.\n\n");
        }

        public string WriteSuperCar()
        {
            return (IsSuperCar) ? "is a Supercar" : "is not a Supercar";
        }

        
    }
}
