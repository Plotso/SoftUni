using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    private double halfModeOreOutput;
    private double halfModeRequirement;
    private double fullModeOreOutput;
    private double fullModeRequirement;

    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
       
    }
    
    public double HalfModeRequirement
    {
        get { return this.halfModeRequirement; }
        set
        {
            this.halfModeRequirement = (60 / 100) * energyRequirement;
        }
    }

    public double HalfModeOreOutput
    {
        get { return this.halfModeOreOutput; }
        set
        {
            this.halfModeOreOutput = (50 / 100) * oreOutput;
        }
    }

    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }
    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput"); //{oreOutput}
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement"); //{energyRequirement}
            }
            //if (value > 20000)
            //{
            //    throw new ArgumentException("Energy requirement cannot be over 20000!");
            //}
            this.energyRequirement = value;
        }
    }
    
}
