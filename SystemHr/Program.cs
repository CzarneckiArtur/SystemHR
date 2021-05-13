using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHr.DataAccessLayer;
using SystemHr.UserInterface.Forms;

namespace SystemHr
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.InitializeConnection(GlobalConfig.ConnectionType);
            Application.Run(new MainForm());
        }
    }
}
