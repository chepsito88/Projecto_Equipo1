using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiVot_Vista;
using DigiVot_Modelo;
using System.Data;
using System.Windows.Forms;

namespace DigiVot_Controlador
{
    public class Controlador_Principal
    {

        #region Declaracion de Variables
        Vista_Principal vPrincipal;
        VO_User voUser;       
        string _Rol;
        private bool esColapzadoAltas;
        private bool esColapzadoReportes;
        private bool esColapzadoAsignaciones;
        private bool esColapzadoConfiguraciones;
        private static bool esColapzadoAyuda;
        #endregion

        public Controlador_Principal(Vista_Principal vPrincipal,VO_User voUser)
        {
            this.vPrincipal = vPrincipal;
            this.voUser = voUser;
            Iniciar();
            Eventos_Botones();
            Eventos_Timer();
            vPrincipal.tmrColapzarAltas.Start();
            vPrincipal.tmrColapzarReportes.Start();
            vPrincipal.tmrColapzarAsignaciones.Start();
            vPrincipal.tmrColapzarConfiguraciones.Start();
            vPrincipal.tmrColapzarAyuda.Start();
        }
        private void Eventos_Timer()
        {
            vPrincipal.tmrColapzarAltas.Tick += TickTmrAltas;
            vPrincipal.tmrColapzarReportes.Tick += TickTmrReportes;
            vPrincipal.tmrColapzarAsignaciones.Tick += TickTmrAsignaciones;
            vPrincipal.tmrColapzarConfiguraciones.Tick += TickTmrConfiguraciones;
            vPrincipal.tmrColapzarAyuda.Tick += TickTmrAyuda;
        }
        private void Eventos_Botones()
        {
            vPrincipal.btnPerfiles.Click += Peril_Click;
            vPrincipal.btnReglas.Click += Click_Reglas;
            vPrincipal.btnAsignacion.Click += Click_Asignacion;
            vPrincipal.btnSalirApp.Click += Click_SalirApp;
            vPrincipal.btnMinimizar.Click += Click_Minimizar;
            vPrincipal.btnAltas.Click += Click_Altas;
            vPrincipal.btnReportes.Click += Click_Reportes;
            vPrincipal.btnAsignaciones.Click += Click_Asignaciones;
            vPrincipal.btnConfiguracion.Click += Click_Configuraciones;
            vPrincipal.btnAyuda.Click += Click_Ayuda;
        }

        private bool TickTimers(Timer timer,Panel panel,bool esColapzadoPanel)
        {
            if (esColapzadoPanel)
            {
                panel.Height += 10;
                if (panel.Size == panel.MaximumSize)
                {
                    timer.Stop();
                    esColapzadoPanel = false;
                }
            }
            else
            {
                panel.Height -= 10;
                if (panel.Size == panel.MinimumSize)
                {
                    timer.Stop();
                    esColapzadoPanel = true;
                }
            }
            return esColapzadoPanel;
        }
        private void TickTmrAyuda(object sender, EventArgs e)
        {
            esColapzadoAyuda=TickTimers(vPrincipal.tmrColapzarAyuda,vPrincipal.pnlAyuda,esColapzadoAyuda);
        }       
        private void TickTmrConfiguraciones(object sender, EventArgs e)
        {
            esColapzadoConfiguraciones = TickTimers(vPrincipal.tmrColapzarConfiguraciones, vPrincipal.pnlConfiguracion, esColapzadoConfiguraciones);
        }
        private void TickTmrReportes(object sender, EventArgs e)
        {
            esColapzadoReportes = TickTimers(vPrincipal.tmrColapzarReportes, vPrincipal.pnlReportes, esColapzadoReportes);
        }
        private void TickTmrAsignaciones(object sender, EventArgs e)
        {
            esColapzadoAsignaciones = TickTimers(vPrincipal.tmrColapzarAsignaciones, vPrincipal.pnlAsignaciones, esColapzadoAsignaciones);
        }
        private void TickTmrAltas(object sender, EventArgs e)
        {
            esColapzadoAltas = TickTimers(vPrincipal.tmrColapzarAltas, vPrincipal.pnlAltas, esColapzadoAltas);
        }

        private void Click_Ayuda(object sender, EventArgs e)
        {
            vPrincipal.tmrColapzarAyuda.Start();
        }
        private void Click_Configuraciones(object sender, EventArgs e)
        {
            vPrincipal.tmrColapzarConfiguraciones.Start();
        }
        private void Click_Asignaciones(object sender, EventArgs e)
        {
            vPrincipal.tmrColapzarAsignaciones.Start();
        }
        private void Click_Reportes(object sender, EventArgs e)
        {
            vPrincipal.tmrColapzarReportes.Start();
        }
        private void Click_Altas(object sender, EventArgs e)
        {
            vPrincipal.tmrColapzarAltas.Start();
        }
        private void Click_Minimizar(object sender, EventArgs e)
        {
            vPrincipal.WindowState = FormWindowState.Minimized;
        }
        private void Click_SalirApp(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Click_Asignacion(object sender, EventArgs e)
        {
            Vista_Asignador vAsignador = new Vista_Asignador();
            Controlador_Asignador conAsignador = new Controlador_Asignador(vAsignador);
            AbrirFormulario<Vista_Asignador>();
        } 
        private void Click_Reglas(object sender, EventArgs e)
        {
            Vista_Reglas visReglas = new Vista_Reglas();
            VO_Reglas voReglas = new VO_Reglas();
            Controlador_Reglas conReglas = new Controlador_Reglas(visReglas,voReglas);
            AbrirFormulario<Vista_Reglas>();
        }
        private void Peril_Click(object sender, EventArgs e)
        {
            Vista_Perfiles vPerfil = new Vista_Perfiles();
            VO_Perfiles voPerfil = new VO_Perfiles();
            Controlador_Perfil cPerfil = new Controlador_Perfil(vPerfil,voPerfil);
            AbrirFormulario<Vista_Perfiles>();
        }
        private void Iniciar()
        {
            _Rol= voUser.Puesto;
            vPrincipal.Text = "Bienvenido: " + voUser.Nombre;
            vPrincipal.lblNomUsuario.Text = voUser.Nombre;
            Permisos();
        }
        private void Permisos()
        {
            if (voUser.Puesto!= "Administrador")
            {
                vPrincipal.pnlConfiguracion.Visible = false;
            }

            vPrincipal.pnlAltas.Visible = TieneRegla("4");

        }
        bool TieneRegla(string Reglas_checar)
        {
            string[] Reglas = Reglas_checar.Split(',');
            foreach (var s in Reglas)
            {
                if (s != "" && voUser.Reglas.Contains(s))
                {
                    return true;
                }
            }
            return false;
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = vPrincipal.pnlContenedorFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colexion el formulario
            //Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                vPrincipal.pnlContenedorFormularios.Controls.Add(formulario);
                vPrincipal.pnlContenedorFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/ Instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
    }
}
