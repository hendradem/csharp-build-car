using System;

namespace Vehicle {
    class Program {
        static void Main(string[] args) {

            string buildCar(){
                // Build the engine
                Engine myEngine = new Engine(4, 250);
                int cylinder = myEngine.getEngineCylinder();
                int maxspeed = myEngine.getEngineMaxSpeed();
                string engineData = "Engine " + cylinder + " Cylinder Up to " + maxspeed + " KM/H Top Speed";
                
                // Build the car based engine data above
                Car myCar = new Car("H-RV", engineData, "100");
                string type = myCar.getCarType();
                string engine = myCar.getCarEngine();
                string fuel = myCar.getCarFuel();

                // Display final result
                string myFinalCar = "My car is " + type + " With " + engine + " and my car fuel is " + fuel;
                Console.WriteLine(myFinalCar);
                
                return null;
            }
            
            // Print to console
            Console.WriteLine(buildCar());
            
        }
    }
}