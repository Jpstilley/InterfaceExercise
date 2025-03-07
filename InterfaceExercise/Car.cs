﻿using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool IsSuperCar { get; set; }
        public int NumberOfDoors { get; set; }

        public int Wheels { get; set; }
        public string EngineType { get; set; }
        public string ExhaustType { get; set; }
        public string FrameMaterial { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public Car()
        {

        }

        public void PrintVehcileInfo()
        {
            Console.WriteLine($"A {Name} {Model} is a {RemoveFirstPart()}.\nIt {WriteSuperCar()} with a {EngineType} and has {NumberOfDoors} doors.\nIt has a {ExhaustType} exhaust and its frame is made of {FrameMaterial}.\n\n");
        }

        public string WriteSuperCar()
        {
            return (IsSuperCar) ? "is a Supercar" : "is not a Supercar";
        }

        public string RemoveFirstPart()
        {
            return GetType().ToString().Remove(0, 18);
        }

        public void HonkHorn()
        {
            Console.WriteLine("meep meep");
        }

        public void Drive()
        {
            Console.WriteLine($"Building a {RemoveFirstPart()}");
        }
    }
}
