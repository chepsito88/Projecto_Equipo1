using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiVot_Vista;
using DigiVot_Controlador;

namespace DigiVot_Aplication
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Vista_Splash vistaSplash = new Vista_Splash();
            Controlador_Splash Splash = new Controlador_Splash(vistaSplash);
            vistaSplash.Show();
            Application.Run();
        }
    }
}
