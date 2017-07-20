namespace _02.HornetCom
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class HornetCom
    {
        public static void Main()
        {
            //var input = Console.ReadLine();
            //var regexMessage = new Regex(@"(\d+)\s<->\s([A-Za-z0-9]+)");
            //var regexBroadcast = new Regex(@"([^\d]+)\s<->\s(\w+)");
            //var broadcastDict = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                var regexMessage = new Regex(@"(\d+)\s<->\s([A-Za-z0-9]+)");
                var regexBroadcast = new Regex(@"([^\d]+)\s<->\s(\w+)");
                var broadcastDict = new Dictionary<string, string>();
                var messageDict = new Dictionary<string, string>();

                var broadcast = regexBroadcast.Match(input);
                var message = regexMessage.Match(input);

                //broadcast
                var frequency = broadcast.Groups[2].Value; // .Value ?!?
                var broadcastMessage = broadcast.Groups[1].Value; // .Value ?!?
                broadcastDict[frequency] = broadcastMessage;


                //private message
                var recipient = message.Groups[1].Value.ToString();
                Reverse(recipient);
                var privateMessage = message.Groups[2].Value;
                messageDict[recipient] = privateMessage;

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
