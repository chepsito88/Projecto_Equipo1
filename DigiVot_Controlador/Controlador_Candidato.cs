using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiVot_Vista;
using DigiVot_Modelo;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace DigiVot_Controlador
{
    class Controlador_Candidato
    {
        Vista_Candidato vCandidato;
        VO_Partidos vo_Partidos = new VO_Partidos();
        VO_Candidato vo_Candidato;
        private ICrud InstanciaPartidos = Construye_Objeto.intancias(6);
        private ICrud InstanciaCandidatos = Construye_Objeto.intancias(5);
        private ICrud InstanciaCiudadanos = Construye_Objeto.intancias(7);
        private ICrud InstanciaEelecciones = Construye_Objeto.intancias(8);
        private string NombreFoto;
        public Controlador_Candidato(Vista_Candidato vCandidato)
        {
            this.vCandidato = vCandidato;
            Eventos_Botones();
            CargarPerfiles();
            CargarTipoEleccion();
            llenaGrid();
        }

        private void Eventos_Botones()
        {
            vCandidato.btnAgregarImagen.Click += Click_AgregarImagen;
            vCandidato.btnBuscar.Click += Click_Buscar;
            vCandidato.btnGuardar.Click += Click_Guardar;
            vCandidato.btnLimpiar.Click += Click_Limpiar;
        }

        private void Click_Limpiar(object sender, EventArgs e)
        {
            refrescar();
        }

        private void Click_Buscar(object sender, EventArgs e)
        {
            if (vCandidato.txtCurp.Text == string.Empty)
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                VO_Ciudadano voCiudadano = new VO_Ciudadano();
                voCiudadano.Curp = vCandidato.txtCurp.Text;
                List<Object> lstCiudadano = InstanciaCiudadanos.Listar(voCiudadano);
                if ((Boolean)lstCiudadano[0])
                {
                    voCiudadano = (VO_Ciudadano)lstCiudadano[1];
                    vCandidato.txtNombre.Text = voCiudadano.Nombre;
                    vCandidato.txtApellidoP.Text = voCiudadano.APaterno;
                    vCandidato.txtApellidoM.Text = voCiudadano.AMaterno;
                }
                else
                {
                    MessageBox.Show("No existe....");
                }
            }
        }

        private void Click_Guardar(object sender, EventArgs e)
        {
            if (vCandidato.txtCurp.Text == "" && NombreFoto=="")
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Candidato.Curp = vCandidato.txtCurp.Text;
                vo_Candidato.IdPartido = Convert.ToInt32(vCandidato.cmbPartidoAsign.SelectedValue);
                vo_Candidato.IdEleccion = Convert.ToInt32(vCandidato.cmbEleccionAsign.SelectedValue);
                vo_Candidato.Foto = NombreFoto;
                if (InstanciaCandidatos.Insertar(vo_Candidato))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    refrescar();
                }
                else
                {
                    MessageBox.Show("Intente nuevamente....");
                }
            }
        }

        private void Click_AgregarImagen(object sender, EventArgs e)
        {
            string URLImagen;
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Selecione el achivo adecuado";
            abrir.Filter = "Archivos (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                URLImagen = abrir.SafeFileName;
                NombreFoto = abrir.FileName;
                //lblImagen.Text = abrir.SafeFileName;
                vCandidato.ptbImagenCandidato.Image = Image.FromFile(abrir.FileName);
            }
            else
            {
                abrir.Dispose();
                MessageBox.Show("No selecionó ningun archivo");
            }
        }

        private void CargarPerfiles()
        {
            vCandidato.cmbPartidoAsign.ValueMember = "Id";
            vCandidato.cmbPartidoAsign.DisplayMember = "Nombre";
            vCandidato.cmbPartidoAsign.DataSource = InstanciaPartidos.Listar(null);
        }
        private void CargarTipoEleccion()
        {
            vCandidato.cmbEleccionAsign.ValueMember = "Id";
            vCandidato.cmbEleccionAsign.DisplayMember = "Nombre";
            vCandidato.cmbEleccionAsign.DataSource = InstanciaEelecciones.Listar(null);
        }
        public void llenaGrid()
        {
            vCandidato.dtgListaCandidatos.DataSource = InstanciaCandidatos.Listar(null);
        }
        public void refrescar()
        {
            vCandidato.txtCurp.Clear();
            vCandidato.txtNombre.Clear();
            vCandidato.txtApellidoP.Clear();
            vCandidato.txtApellidoM.Clear();
            vCandidato.dtgListaCandidatos.ClearSelection();
            NombreFoto = "";
        }
    }
}
