namespace TestProject
{
    using System;
    using System.Timers;

    public class TestProject
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                var timer = new Timer(3000);
                timer.Start();
                timer.Elapsed += new ElapsedEventHandler(OnTimeEvent);
                Console.ReadLine();
                Console.WriteLine(); 
            }
            

        }
        public static void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("BOOM");
        }
    }
}
