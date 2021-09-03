using System;
namespace InterfaceExercise
{
    public abstract class Vehicle : IVehicle, ICompany
    {
        public int Wheels { get; set; }
        public string EngineType { get; set; }
        public string ExhaustType { get; set; }
        public string FrameMaterial { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }



        public Vehicle()
        {
        }

        public abstract void PrintVehcileInfo();

        public virtual string RemoveFirstPart()
        {
            return GetType().ToString().Remove(0, 18);
        }
        

        public void HonkHorn()
        {
            Console.WriteLine("HONK HONK");
        }
    }
}
