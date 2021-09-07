using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces



            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            var newVehcile = VehicleFactory.GetVehicle();
            newVehcile.Drive();

            var murcielago = new Car()
            {
                Name = "Lambourgini",
                Model = "Murcielago",
                Logo = "Bull",
                Wheels = 4,
                EngineType = "V12",
                ExhaustType = "Dual",
                FrameMaterial = "Steel",
                IsSuperCar = true,
                NumberOfDoors = 2
            };

            var silverado = new Truck()
            {
                Name = "Cheverolet",
                Model = "Silverado",
                Logo = "Bowtie",
                Wheels = 4,
                EngineType = "V8",
                ExhaustType = "Dual",
                FrameMaterial = "Steel",
                ExtendedCab = true,
                HasToolBox = true
            };

            var modelX = new SUV()
            {
                Name = "Tesla",
                Model = "Model X",
                Logo = "Bowtie",
                Wheels = 4,
                EngineType = "Electric",
                ExhaustType = "Dual",
                FrameMaterial = "Steel",
                NumberOfSeats = 8,
                HasBackseatVideoScreen = true
            };

            

            var vehicleList = new List<IVehicle>();

            vehicleList.Add(murcielago);
            vehicleList.Add(silverado);
            vehicleList.Add(modelX);
            

            //Creatively display and organize their values

            foreach(var vehicle in vehicleList)
            {
                vehicle.PrintVehcileInfo();
            }

           
        }
    }
}
