using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DraftManager
{
    //private List<Harvester> harvesters;
    //private List<Provider> providers;
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;

    private double allProvidedEnergy;
    private double allRequiredEnergy;
    private double TotalMinedOr;
    public double energyRequiredThisDay;
    public double energyProvidedThisDay;
    public double summedOreOutput;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        //this.allProvidedEnergy = 0;
        //this.allRequiredEnergy = 0;
        //this.summedOreOutput = 0;
    }

    public double AllProvidedEnergy
    {
        get { return this.allProvidedEnergy; }
        set { this.allProvidedEnergy = value; }
    }
    public double AllRequiredEnergy
    {
        get { return this.allRequiredEnergy; }
        set { this.allRequiredEnergy = value; }
    }
    public double TotalMinedOre
    {
        get { return this.TotalMinedOr; }
        set { this.TotalMinedOr = value; }
    }



    //-----------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------


    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);
        try
        {
            if (type == "Sonic")
            {
                var sonicFactor = int.Parse(arguments[4]);

                harvesters.Add(id, new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor));
            }
            else
            {
                harvesters.Add(id, new HammerHarvester(id, oreOutput, energyRequirement));
            }
        }
        catch (ArgumentException ex)
        {

            return ex.Message;
        }
        
        return $"Successfully registered {type} Harvester - {id}"; ;
    }
    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);
        try
        {
            if (type == "Solar")
            {
                providers.Add(id, new SolarProvider(id, energyOutput));
            }
            else
            {
                providers.Add(id, new PressureProvider(id, energyOutput));
            }
        }
        catch (ArgumentException ex)
        {

            return ex.Message;
        }
        
        return $"Successfully registered {type} Provider - {id}";
    }
    public string Day()
    {
        foreach (var provider in providers.Values)
        {
            allProvidedEnergy += provider.EnergyOutput;
            energyProvidedThisDay += provider.EnergyOutput;
        }
        foreach (var harvester in harvesters.Values)
        {
            allRequiredEnergy += harvester.EnergyRequirement;
            energyRequiredThisDay += harvester.EnergyRequirement;
        }
        if (allProvidedEnergy >= energyRequiredThisDay)
        {
            foreach (var harvester in harvesters.Values)
            {
                TotalMinedOr += harvester.OreOutput;
                summedOreOutput += harvester.OreOutput;
                
            }
            allProvidedEnergy -= energyRequiredThisDay;
        }
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"A day has passed.")
            .AppendLine($"Energy Provided: {allProvidedEnergy}")
            .AppendLine($"Plumbus Ore Mined: {TotalMinedOr}");

        energyProvidedThisDay = 0;
        energyRequiredThisDay = 0;
        summedOreOutput = 0;
        return sb.ToString();
        
    }
    public string Mode(List<string> arguments)
    {
        var mode = arguments[0];
        if (mode == "Half")
        {
            return $"Successfully changed working mode to {mode} Mode";
        }
        else if (mode == "Energy")
        {
            return $"Successfully changed working mode to {mode} Mode";
        }
        else
        {
            return $"Successfully changed working mode to {mode} Mode";
        }
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        if (harvesters.ContainsKey(id))
        {
            return harvesters[id].ToString();
        }
        else if (providers.ContainsKey(id))
        {
            return providers[id].ToString();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }
    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"System Shutdown")
            .AppendLine($"Total Energy Stored: {allProvidedEnergy}")
            .AppendLine($"Total Mined Plumbus Ore: {TotalMinedOre}");
        return sb.ToString();
    }

}

