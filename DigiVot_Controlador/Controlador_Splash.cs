using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiVot_Vista;

namespace DigiVot_Controlador
{
    public class Controlador_Splash : ApplicationContext
    {
        Vista_Splash vSplash;
        public Controlador_Splash(Vista_Splash vSplash)
        {
            this.vSplash = vSplash;
            iniciar();
            vSplash.MouseDown += Movimiento_Mouse;
            vSplash.tmrTiempo.Tick += Tick;
            vSplash.FormClosing += Cerrando;
        }

        public void iniciar() {
            vSplash.StartPosition = FormStartPosition.CenterScreen;
           
            
        }

        private void Cerrando(object sender, FormClosingEventArgs e)
        {
            Vista_Login vLogin = new Vista_Login();
            Controlador_Login conLogin = new Controlador_Login(vLogin);
            vLogin.StartPosition = FormStartPosition.CenterScreen;
            vLogin.Show();
        }

        private void Tick(object sender, EventArgs e)
        {
            if (vSplash.pnl2.Width < 320)
            {
                vSplash.pnl2.Width = vSplash.pnl2.Width + 10;
            }
            else
            {
                vSplash.tmrTiempo.Enabled = false;
                this.vSplash.Close();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Movimiento_Mouse(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(vSplash.Handle, 0x112, 0xf012, 0);
        }
    }
}
