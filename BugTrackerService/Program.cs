using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Topshelf;

namespace BugTrackerService
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<ProcessTrigger>(s =>
                {
                    s.ConstructUsing(processTrigger => new ProcessTrigger());
                    s.WhenStarted(processTrigger => processTrigger.Start());
                    s.WhenStopped(processTrigger => processTrigger.Stop());
                });
                x.RunAsLocalSystem();
                x.SetDescription("Will parse received bug reports into reports which are then sent to the Development Team.");
                x.SetServiceName("BugTrackerService");
                x.SetDisplayName("Bug Tracker Service Host");

            });
            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
