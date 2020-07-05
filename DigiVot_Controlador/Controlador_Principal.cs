﻿using System;
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
    class Controlador_Principal
    {
        DigiVot_Vista.Vista_Principal vPrincipal;
        VO_User voUser;       
        string _Rol;              
        public Controlador_Principal(DigiVot_Vista.Vista_Principal vPrincipal,VO_User voUser)
        {
            this.vPrincipal = vPrincipal;
            this.voUser = voUser;
            Iniciar();
            vPrincipal.btnPerfiles.Click += Peril_Click;
            vPrincipal.btnReglas.Click += Click_Reglas;
            vPrincipal.btnAsignacion.Click += Click_Asignacion;
            vPrincipal.FormClosing += Cerrando;
           
        }

        private void Cerrando(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Click_Asignacion(object sender, EventArgs e)
        {
            Vista_Asignador vAsignador = new Vista_Asignador();
            Controlador_Asignador conAsignador = new Controlador_Asignador(vAsignador);
            vAsignador.MdiParent = vPrincipal;
            vAsignador.StartPosition = FormStartPosition.CenterScreen;
            vAsignador.Show();
        }

        private void Click_Reglas(object sender, EventArgs e)
        {
            Vista_Reglas visReglas = new Vista_Reglas();
            VO_Reglas voReglas = new VO_Reglas();
            Controlador_Reglas conReglas = new Controlador_Reglas(visReglas,voReglas);
            visReglas.MdiParent = vPrincipal;
            visReglas.StartPosition = FormStartPosition.CenterScreen;
            visReglas.Show();
        }

        private void Peril_Click(object sender, EventArgs e)
        {
            Vista_Perfiles vPerfil = new Vista_Perfiles();
            VO_Perfiles voPerfil = new VO_Perfiles();
            Controlador_Perfil cPerfil = new Controlador_Perfil(vPerfil,voPerfil);
            vPerfil.MdiParent = vPrincipal;
            vPerfil.StartPosition = FormStartPosition.CenterScreen;
            vPerfil.Show();
        }

        private void Iniciar()
        {
            _Rol= voUser.Puesto;
            vPrincipal.Text = "Bienvenido: " + voUser.Nombre;
            Permisos();
     
        }

        private void Permisos()
        {
            if (voUser.Puesto!= "Administrador")
            {
                vPrincipal.mnuConfinguracion.Visible = false;
            }

            vPrincipal.mnuAltas.Visible = TieneRegla("4");

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
    }
}