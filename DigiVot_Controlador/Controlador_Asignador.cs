using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiVot_Vista;
using DigiVot_Modelo;
using System.Windows.Forms;

namespace DigiVot_Controlador
{
    class Controlador_Asignador
    {
        private Vista_Asignador vAsignador;
        private VO_Perfiles voPerfil = new VO_Perfiles();
        private ICrud InstanciaPerfiles = Construye_Objeto.intancias(1);

        private ICrud Instancia = Construye_Objeto.intancias(3);
        object Clase;

        public Controlador_Asignador(Vista_Asignador vAsignador)
        {
            this.vAsignador = vAsignador;
           
            vAsignador.cmbPerfiles.ValueMember = "Id";
            vAsignador.cmbPerfiles.DisplayMember = "NombreTipo";
            vAsignador.cmbPerfiles.DataSource = InstanciaPerfiles.Listar(null);
            vAsignador.cmbPerfiles.SelectedValueChanged += Cambio_Combo;
        }

        private void Cambio_Combo(object sender, EventArgs e)
        {
            voPerfil.Id = Convert.ToInt32(vAsignador.cmbPerfiles.SelectedValue);
            Object VO = voPerfil;
            vAsignador.dtReglas.DataSource = Instancia.Listar(VO);
        }

       
    }
}
