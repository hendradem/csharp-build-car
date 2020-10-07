namespace Vehicle {
    public class Car{
        private string CarType;
        private string CarEngine;
        private string CarFuel;

        public Car(string type, string engine, string fuel) {
            this.CarType = type;
            this.CarEngine = engine;
            this.CarFuel = fuel;
        }
        
        // Get Car data
        public string getCarType() {
            return this.CarType;
        }
        public string getCarEngine() {
            return this.CarEngine;
        }
        public string getCarFuel() {
            return this.CarFuel;
        }
        
    }
}