namespace Vehicle {
    public class Engine {
        private int CylinderVolume;
        private int MaxSpeed;
        
        public Engine(int cylinder, int maxSpeed) {
            this.CylinderVolume = cylinder;
            this.MaxSpeed = maxSpeed;
        }

        //  Get engine data
        public int getEngineCylinder(){
            return this.CylinderVolume;
        }
        public int getEngineMaxSpeed(){
            return this.MaxSpeed;
        }


    }
}