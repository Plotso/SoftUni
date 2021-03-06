﻿using System;
using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.HorsePower = horsepower * 3 / 2;
        this.Suspension -= suspension * 25 / 100;
        this.addOns = new List<string>();
    }

    public override string ToString()
    {
        var result = base.ToString();
        StringBuilder sb = new StringBuilder(base.ToString());

        if (this.addOns.Count > 0)
        {
            sb.AppendLine("Add-ons: " + string.Join(", ", addOns));
        }
        else
        {
            sb.AppendLine("Add-ons: None");
        }

        return sb.ToString().Trim();
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        this.addOns.Add(addOn);
    }
}
