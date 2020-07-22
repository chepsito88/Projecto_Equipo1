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
        VO_Candidato vo_Candidato=new VO_Candidato();
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
            vCandidato.btnEliminar.Click += Click_Eliminar;
            vCandidato.btnEditar.Click += Click_Modificar;
            vCandidato.dtgListaCandidatos.CellDoubleClick += Click_Doble;
        }

        private void Click_Doble(object sender, DataGridViewCellEventArgs e)
        {
            vCandidato.txtCurp.Text = vCandidato.dtgListaCandidatos.Rows[vCandidato.dtgListaCandidatos.CurrentRow.Index].Cells[0].Value.ToString();
            vCandidato.txtNombre.Text = vCandidato.dtgListaCandidatos.Rows[vCandidato.dtgListaCandidatos.CurrentRow.Index].Cells[1].Value.ToString();
            vCandidato.txtApellidoP.Text = vCandidato.dtgListaCandidatos.Rows[vCandidato.dtgListaCandidatos.CurrentRow.Index].Cells[2].Value.ToString();
            vCandidato.txtApellidoM.Text = vCandidato.dtgListaCandidatos.Rows[vCandidato.dtgListaCandidatos.CurrentRow.Index].Cells[3].Value.ToString();
            vCandidato.cmbPartidoAsign.SelectedValue = int.Parse(vCandidato.dtgListaCandidatos.Rows[vCandidato.dtgListaCandidatos.CurrentRow.Index].Cells[5].Value.ToString());
            vCandidato.cmbEleccionAsign.SelectedValue = int.Parse(vCandidato.dtgListaCandidatos.Rows[vCandidato.dtgListaCandidatos.CurrentRow.Index].Cells[7].Value.ToString());
            //vCandidato.ptbImagenCandidato.Image= Image.FromFile(vCandidato.dtgListaCandidatos.Rows[vCandidato.dtgListaCandidatos.CurrentRow.Index].Cells[8].Value.ToString());
        }

        private void Click_Modificar(object sender, EventArgs e)
        {
            int num = vCandidato.dtgListaCandidatos.RowCount;
            if (num == 0)
            {
                MessageBox.Show("Imposible modificar!!! tabla sin datos.......");
            }
            else
            {
                if (vCandidato.dtgListaCandidatos.CurrentRow.Selected == false)
                {
                    MessageBox.Show("Seleccione Registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    vo_Candidato.Curp = vCandidato.dtgListaCandidatos.Rows[vCandidato.dtgListaCandidatos.CurrentRow.Index].Cells[0].Value.ToString();
                    vo_Candidato.IdPartido = Convert.ToInt32(vCandidato.cmbPartidoAsign.SelectedValue);
                    vo_Candidato.IdEleccion = Convert.ToInt32(vCandidato.cmbEleccionAsign.SelectedValue);
                    vo_Candidato.Foto = NombreFoto;
                    if (InstanciaCandidatos.Modificar(vo_Candidato))
                    {
                        MessageBox.Show("Modificado correctamente....");
                        llenaGrid();
                        refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Intente nuevamente....");
                    }
                }
            }
        }

        private void Click_Eliminar(object sender, EventArgs e)
        {
            int num = vCandidato.dtgListaCandidatos.RowCount;
            if (num == 0)
            {
                MessageBox.Show("Imposible eliminar!!! tabla sin datos.......");
            }
            else
            {
                if (vCandidato.dtgListaCandidatos.CurrentRow.Selected == false)
                {
                    MessageBox.Show("Seleccione Registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    vo_Candidato.Curp = vCandidato.dtgListaCandidatos.Rows[vCandidato.dtgListaCandidatos.CurrentRow.Index].Cells[0].Value.ToString();
                    if (InstanciaCandidatos.Eliminar(vo_Candidato))
                    {
                        MessageBox.Show("Eliminado correctamente....");
                        llenaGrid();
                        refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Intente nuevamente....");
                    }
                }
            }
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
            if (vCandidato.txtCurp.Text == "" || NombreFoto=="")
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
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Selecione el achivo adecuado";
            abrir.Filter = "Archivos (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                NombreFoto =abrir.FileName.Substring(abrir.FileName.LastIndexOf("\\") + 1);
                vCandidato.ptbImagenCandidato.Image = Image.FromFile(abrir.FileName);
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
            vCandidato.ptbImagenCandidato.Image = null;
        }
    }
}
