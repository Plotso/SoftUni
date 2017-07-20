using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private DraftManager manager;
    public Engine()
    {
        this.manager = new DraftManager();
    }
    public  void Run()
    {
        var commands = Console.ReadLine();

        while (commands != "Shutdown")
        {
            var cmdArgs = commands.Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = cmdArgs[0];
            var arguments = cmdArgs.Skip(1).Take(cmdArgs.Count - 1).ToList();

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(manager.RegisterHarvester(arguments));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(manager.RegisterProvider(arguments));
                    break;
                case "Day":
                    Console.WriteLine(manager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(manager.Mode(arguments));
                    break;
                case "Check":
                    Console.WriteLine(manager.Check(arguments));
                    break;
            }

            commands = Console.ReadLine();
        }
        Console.WriteLine(manager.ShutDown());
    }
}

