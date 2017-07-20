using System;
using System.Collections.Generic;

public class Garage
{
    public List<int> ParkedCars { get; set; }

    public Garage()
    {
        this.ParkedCars = new List<int>();
    }

    public void AddCar(int id)
    {
        this.ParkedCars.Add(id);
    }

    internal void RemoveCar(int id)
    {
        this.ParkedCars.Remove(id);
    }
}
