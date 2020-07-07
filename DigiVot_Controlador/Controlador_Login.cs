using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiVot_Modelo;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DigiVot_Vista;

namespace DigiVot_Controlador
{
    public class Controlador_Login
    {
        Vista_Login Vista;
        private ICrud Instancia = Construye_Objeto.intancias(4);

        public Controlador_Login(Vista_Login Vista)
        {
            this.Vista = Vista;
            //this.Modelo = Modelo;
            Eventos();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Eventos()
        {
            Vista.MouseDown += vista_MouseDown;
            Vista.pktCerrar.Click += pkt_Cerrar;
            Vista.panel1.MouseDown += vista_MouseDown;
            Vista.btnAcceder.Click += btnAcceder_Click;
            Vista.txtUsuario.KeyPress += txt_KeyPress;
            Vista.txtContrasena.KeyPress += txt1_KeyPress;

        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Vista.eprvUno.Clear();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Vista.eprvUno.Clear();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            int x = 0;

            foreach (Control con in Vista.Controls)
            {
                if (con is PlaceholderTextBox.PlaceholderTextBox)
                {
                    if (con.Text == "" || con.Text == "-------")
                    {
                        
                    }
                }
            }

            if (x == 0)
            {
                Login();
            }
        }

        private void Login()
        {
            VO_User voUser = new VO_User();
            voUser.Nombre = Vista.txtUsuario.Text;
            voUser.password = Vista.txtContrasena.Text;
            List<Object> lstLogin = Instancia.Listar(voUser);
            if ((Boolean)lstLogin[0])
            {
                Vista_Principal vPrincipal = new Vista_Principal();
                Controlador_Principal cPrincipal = new Controlador_Principal(vPrincipal, (VO_User)lstLogin[1]);
                vPrincipal.WindowState = FormWindowState.Maximized;
                vPrincipal.Show();
                Vista.Close();
            }
            else
            {
                MessageBox.Show("Acceso Denegado....");
            }

        }

        private void pkt_Cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vista_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Vista.Handle, 0x112, 0xf012, 0);
        }
	      
    }
}
