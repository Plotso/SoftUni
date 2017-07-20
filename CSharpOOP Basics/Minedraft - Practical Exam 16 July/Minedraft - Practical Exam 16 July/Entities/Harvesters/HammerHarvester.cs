using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput = oreOutput * 3;
        this.EnergyRequirement = energyRequirement * 2;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Hammer Harvester - {base.Id}")
            .AppendLine($"Ore Output: {base.OreOutput}")
            .AppendLine($"Energy Requirement: {base.EnergyRequirement}");

        return sb.ToString();
    }
}

