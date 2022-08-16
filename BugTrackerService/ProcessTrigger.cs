using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BugTrackerService
{
    public class ProcessTrigger
    {
        
        private readonly Timer _timer;
        public ProcessTrigger()
        {
            //Elapses every minute to check the time
            _timer = new Timer(60000) { AutoReset = true};
            _timer.Elapsed += timer_Elapsed;
        }

        /// <summary>
        /// Determine the day and time, trigger accordingly.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer_Elapsed(object sender, ElapsedEventArgs e) 
        {
            //if Not a weekend ;)
            if (DateTime.Now.DayOfWeek != DayOfWeek.Saturday || DateTime.Now.DayOfWeek != DayOfWeek.Sunday) 
            {
                //Generate Notification Emails at 9am Weekdays.
                if (DateTime.Now.Hour == 9 && DateTime.Now.Minute == 0) 
                {
                    ProcessRequest processRequest = new ProcessRequest();
                }
            }
        }

        public void Start() 
        {
            _timer.Start();
        }
        public void Stop() 
        {
            _timer.Stop();
        }
    }
}
