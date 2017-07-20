using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SonicHarvester : Harvester
{
    private int sonicFactor;  //should be added to the constructor!!!


    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) 
        : base(id, oreOutput, energyRequirement)
    {
        this.sonicFactor = sonicFactor;
        this.EnergyRequirement = energyRequirement / sonicFactor;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Sonic Harvester - {base.Id}")
            .AppendLine($"Ore Output: {base.OreOutput}")
            .AppendLine($"Energy Requirement: {base.EnergyRequirement}");

        return sb.ToString();
    }
}

