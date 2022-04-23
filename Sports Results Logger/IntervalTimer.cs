using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Sports_Results_Logger
{
    public class IntervalTimer
    {
        private static Timer timer;
        public static void BeginTimer()
        {
            timer = new Timer();
            
            timer.Interval = 900_000;

            timer.Elapsed += OnTimedEvent;

            timer.AutoReset = true;

            timer.Enabled = true;

            Console.WriteLine("Press Enter to exit the Application... ");
            Console.ReadLine();
        }

        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"15 Minute email interval check at {e.SignalTime}");
            EmailService.SendEmailProcess();
        }
    }
}
