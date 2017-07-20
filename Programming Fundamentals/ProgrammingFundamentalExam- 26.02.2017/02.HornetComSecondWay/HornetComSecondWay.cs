namespace _02.HornetComSecondWay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;


    public class HornetComSecondWay
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regexMessage = new Regex(@"(\d+)\s<->\s([A-Za-z0-9]+)\s");
            var regexBroadcast = new Regex(@"([^\d]+)\s<->\s(\w+)");
            var broadcastDict = new Dictionary<string, string>();
            var messageDict = new Dictionary<string, List<string>>();
            while (true)
            {
                
                if (input == "Hornet is Green")
                {
                    break;
                }
                //var regexMessage = new Regex(@"(\d+)\s<->\s([A-Za-z0-9]+)");
                //var regexBroadcast = new Regex(@"([^\d]+)\s<->\s(\w+)");
                

                var broadcast = regexBroadcast.Match(input);
                var message = regexMessage.Match(input);

                //broadcast
                if (broadcast.Success)
                {
                    var frequency = broadcast.Groups[2].Value; // .Value ?!?
                    var broadcastMessage = broadcast.Groups[1].Value; // .Value ?!?

                    string newStr = "";
                    foreach (var letter in frequency)
                    {
                        if (Char.IsLetter(letter))
                        {
                            if (Char.IsLower(letter))
                            {
                               newStr += Char.ToUpper(letter);
                               //var newLetter = Char.ToUpper(letter) ;
                                //letter.Replace(newLetter);
                            }
                            else 
                            {
                                newStr += Char.ToLower(letter);
                                //var newLetter = Char.ToLower(letter);
                                //frequency.Replace(letter, newLetter);
                            }
                            
                        }
                        else
                        {
                            newStr += letter;
                        }
                    }

                    if (broadcastDict.ContainsKey(newStr))
                    {
                        broadcastDict.Add(newStr, string.Empty);
                    }
                    broadcastDict[newStr] = broadcastMessage;

                }
                 if (message.Success)
                {
                    //private message
                    var recipient = message.Groups[1].Value.ToString();
                    recipient = Reverse(recipient);
                    var privateMessage = message.Groups[2].Value;
                    if (messageDict.ContainsKey(recipient))
                    {
                        //messageDict.Add(recipient, privateMessage);
                        messageDict[recipient].Add(privateMessage);
                    }
                    else
                    {
                        messageDict[recipient] = new List<string> { privateMessage };
                    }
                    //messageDict[recipient] = privateMessage;

                }



                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcastDict.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcastDict)
                {
                    var frequency = item.Key;
                    var message = item.Value;
                    Console.WriteLine($"{frequency} -> {message}");
                }
            }
            Console.WriteLine("Messages:");
            if (messageDict.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in messageDict)
                {
                    var recipient = item.Key;
                    var messages = item.Value;
                    foreach (var message in messages)
                    {
                        Console.WriteLine($"{recipient} -> { message}");
                    }
                    
                }
            }
            

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
