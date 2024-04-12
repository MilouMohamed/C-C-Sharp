using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_STOCK_V1._1._1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LOGIN());
            //  Application.Run(new MATERIEL());
            // Application.Run(new LIST_M());
           //  Application.Run(new ENTRE_SORTIR());
            //  Application.Run(new LES_RAPORTS()); 
        }
    }
}
