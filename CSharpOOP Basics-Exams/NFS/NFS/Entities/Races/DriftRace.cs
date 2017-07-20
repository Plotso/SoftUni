using System;

public class DriftRace : Race
{
    private int suspensionPerformance;

    public DriftRace(int length, string route, int prizePool) 
        : base(length, route, prizePool)
    {
    }

    public int SuspensionPerformance { get; set; }

    public override int GetPerformance(int id)
    {
        var car = this.Participants[id];

        return car.Suspension + car.Durability;
    }
}
