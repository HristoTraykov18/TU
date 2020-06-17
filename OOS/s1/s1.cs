using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace s1
{
    public partial class s1 : ServiceBase
    {
        public s1(string[] args)
        {
            InitializeComponent();

            string eventSourceName = "MySource";
            string logName = "MyNewLog";

            if (args.Length > 0)
            {
                eventSourceName = args[0];
                Console.WriteLine(args[0]);
            }

            if (args.Length > 1)
            {
                logName = args[1];
            }

            if (args.Length > 2)
            {
                logName = args[2];
            }

            eventLog1 = new EventLog();

            /*if (!EventLog.SourceExists(eventSourceName))
                EventLog.CreateEventSource(eventSourceName, logName);

            eventLog1.Source = eventSourceName;
            eventLog1.Log = logName;*/
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {
        }
    }
}
