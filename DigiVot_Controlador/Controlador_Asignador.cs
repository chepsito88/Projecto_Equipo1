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
        private VO_PerfilReglas voPerfilReglas;
        private ICrud InstanciaPerfiles = Construye_Objeto.intancias(1);
        private ICrud Instancia = Construye_Objeto.intancias(3);        

        public Controlador_Asignador(Vista_Asignador vAsignador)
        {
            this.vAsignador = vAsignador;
            CargarPerfiles();
            vAsignador.cmbPerfiles.SelectedValueChanged += Cambio_Combo;
            vAsignador.dtReglas.DataBindingComplete += Limpiar;
            vAsignador.chkAll.CheckedChanged += Cambio_Check;
            vAsignador.btnGuardar.Click += Guardar_Click;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            voPerfilReglas = new VO_PerfilReglas();
            voPerfilReglas.idPerfil= Convert.ToInt32(vAsignador.cmbPerfiles.SelectedValue);            
            string separador = "";
            foreach (DataGridViewRow row in vAsignador.dtReglas.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Selected"].Value))
                {
                    voPerfilReglas.Regla += separador + row.Cells["id"].Value;
                    separador = ",";
                }
            }
            Instancia.Insertar(voPerfilReglas);
        }

        private void Cambio_Check(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in vAsignador.dtReglas.Rows)
            {
                DataGridViewCheckBoxCell chkSeleccioando = 
                    (DataGridViewCheckBoxCell)row.Cells["Selected"];
                chkSeleccioando.Value = vAsignador.chkAll.Checked;

            }
        }

        private void CargarPerfiles()
        {
            vAsignador.cmbPerfiles.ValueMember = "Id";
            vAsignador.cmbPerfiles.DisplayMember = "NombreTipo";
            vAsignador.cmbPerfiles.DataSource = InstanciaPerfiles.Listar(null);
        }

        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vAsignador.dtReglas.ClearSelection();
        }

        private void Cambio_Combo(object sender, EventArgs e)
        {
            voPerfil.Id = Convert.ToInt32(vAsignador.cmbPerfiles.SelectedValue);
            Object VO = voPerfil;
            vAsignador.dtReglas.DataSource = Instancia.Listar(VO);
            vAsignador.dtReglas.Columns[2].Visible = false;

        }

       
    }
}
