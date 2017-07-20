namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Timers;

    public class TimerClass
    {
        public static void Main()
        {
            var timer = new Timer();
            timer.Interval = 3000;
            timer.Elapsed += new ElapsedEventHandler(OnTimeEvent);
            timer.Interval = 3000;
            //timer.Enabled = true;
            Console.WriteLine();
            
        }

        public static void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("BOOM");
        }
    }
}
//var timer = new Timer(3);

//timer.Start();
//            Console.WriteLine(timer);
//            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
//            if (KeyInfo.Key == ConsoleKey.Spacebar)
//            {
                
//                timer.Stop();
//            }
