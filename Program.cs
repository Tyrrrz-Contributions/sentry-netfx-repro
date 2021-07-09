using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentry;

namespace sentry_repro
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SentrySdk.Init("https://eb18e953812b41c3aeb042e666fd3b5c@o447951.ingest.sentry.io/5428537");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            SentrySdk.FlushAsync(TimeSpan.FromSeconds(10)).GetAwaiter().GetResult();
        }
    }
}