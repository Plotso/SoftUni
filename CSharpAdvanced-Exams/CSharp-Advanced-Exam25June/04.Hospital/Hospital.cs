namespace _04.Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Hospital
    {
        public static void Main()
        {
            var roomsInDepartment = 20;
            var bedsInRoom = 3;

            var departmentTotalCapacity = roomsInDepartment * bedsInRoom;

            var departmentDictionary = new Dictionary<string, Dictionary<int, List<string>>>();
            var depDictCounter = new Dictionary<string, int>();
            var doctorDictionary = new Dictionary<string, List<string>>();
            var departmentDictionaryOnlyStrings = new Dictionary<string, List<string>>();

            var information = Console.ReadLine();

            while (information != "Output")
            {
                var tokens = information
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var department = tokens[0];
                var doctorFirstName = tokens[1].ToString();
                var doctorLastName = tokens[2].ToString();
                var patient = tokens[3];

                var doctorFullName = doctorFirstName + " " + doctorLastName;

                if (!doctorDictionary.ContainsKey(doctorFullName))
                {
                    doctorDictionary.Add(doctorFullName, new List<string>());
                }
                doctorDictionary[doctorFullName].Add(patient);

                if (!departmentDictionary.ContainsKey(department))
                {
                    departmentDictionary.Add(department, new Dictionary<int, List<string>>());
                    depDictCounter.Add(department, 1);
                    departmentDictionary[department].Add(1, new List<string>() { patient });

                    departmentDictionaryOnlyStrings.Add(department, new List<string>());
                    departmentDictionaryOnlyStrings[department].Add(patient);
                }
                else
                {

                    var roomNow = depDictCounter[department];
                    if (roomNow == 20 && departmentDictionary[department][roomNow].Count == 3)
                    {
                        continue;
                    }
                    else
                    {
                        if (departmentDictionary[department][roomNow].Count == 3)
                        {
                            departmentDictionary[department].Add(roomNow + 1, new List<string>() { patient });
                            depDictCounter[department]++;
                        }
                        else
                        {
                            departmentDictionary[department][roomNow].Add(patient);
                        }
                        departmentDictionaryOnlyStrings[department].Add(patient);

                    }

                }
                information = Console.ReadLine();
            }

            var commands = Console.ReadLine();

            while (commands != "End")
            {
                var improvisedCommand = commands.Split().ToArray();
                if (doctorDictionary.ContainsKey(commands))
                {
                    foreach (var doctors in doctorDictionary)
                    {
                        var doctorName = doctors.Key;
                        if (doctorName == commands)
                        {

                            foreach (var patient in doctors.Value.OrderBy(x => x))
                            {
                                Console.WriteLine(patient);
                            }
                        }
                    }
                }

                else if (departmentDictionaryOnlyStrings.ContainsKey(commands))
                {
                    foreach (var department in departmentDictionaryOnlyStrings)
                    {
                        var departmentName = department.Key;
                        if (departmentName == commands)
                        {
                            foreach (var patient in department.Value)
                            {
                                Console.WriteLine(patient);
                            }
                        }
                    }
                }
                else if (departmentDictionary.ContainsKey(improvisedCommand[0]) && depDictCounter.ContainsValue(int.Parse(improvisedCommand[1])))
                {
                    foreach (var department in departmentDictionary)
                    {
                        var name = department.Key;
                        if (name == improvisedCommand[0])
                        {
                            foreach (var room in department.Value)
                            {
                                var roomN = room.Key;
                                foreach (var patient in room.Value.OrderBy(x => x))
                                {
                                    Console.WriteLine(patient);
                                }
                            }
                        }
                    }
                }
                commands = Console.ReadLine();
            }
        }
    }
}
