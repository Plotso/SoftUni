namespace _04.FollowingExercises
{
    using System;

    public class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelConsumptionPer1Km;
        public double distanceTraveled;

        public Car(string model, double fuelAmount, double fuelConsumptionPer1Km)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPer1Km = fuelConsumptionPer1Km;
            this.distanceTraveled = 0;
        }

        public void Drive(double distance)
        {
            if (this.fuelAmount < distance * this.fuelConsumptionPer1Km)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmount -= distance * this.fuelConsumptionPer1Km;
                this.distanceTraveled += distance;
            }
        }
    }
}
