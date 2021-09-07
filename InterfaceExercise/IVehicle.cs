using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {

        public int Wheels { get; set; }
        public string EngineType { get; set; }
        public string ExhaustType { get; set; }
        public string FrameMaterial { get; set; }

        public void HonkHorn();

        public void PrintVehcileInfo();

        public string RemoveFirstPart();

        public void Drive();
    }
}
