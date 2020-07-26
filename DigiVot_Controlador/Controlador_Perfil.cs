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
    class Controlador_Perfil
    {
        private Vista_Perfiles vPerfil;
        private VO_Perfiles voPerfil;
        private ICrud Instancia = Construye_Objeto.intancias(1);


        public Controlador_Perfil(Vista_Perfiles vPerfil, VO_Perfiles voPerfil)
        {
            this.vPerfil = vPerfil;
            this.voPerfil = voPerfil;
            vPerfil.btnGuardar.Click += Guardar_Click;
            vPerfil.dtPerfiles.CellDoubleClick += Doble_Click;
            vPerfil.btnEditar.Click += Modificar_Click;
            vPerfil.btnEliminar.Click += Eliminar_Click;
            vPerfil.btnLimpiar.Click += Limpiar_Click;
            llenaGrid();
            vPerfil.dtPerfiles.Columns[0].Visible = false;
            vPerfil.dtPerfiles.DataBindingComplete += Limpiar;            

        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            if (vPerfil.txtPerfil.Text=="" && vPerfil.txtDescripcion.Text=="")
            {
                MessageBox.Show("Campos requeridos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                voPerfil.NombreTipo = vPerfil.txtPerfil.Text;
                voPerfil.Descripcion = vPerfil.txtDescripcion.Text;             
                if (Instancia.Insertar(voPerfil))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Intente nuevamente....");
                }
            }

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            int num = vPerfil.dtPerfiles.RowCount;
            if (num == 0)
            {
                MessageBox.Show("Imposible modificar!!! tabla sin datos.......");
            }
            else
            {
                if (vPerfil.dtPerfiles.CurrentRow.Selected == false)
                {
                    MessageBox.Show("Seleccione Registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    voPerfil.Id = int.Parse(vPerfil.dtPerfiles.Rows[vPerfil.dtPerfiles.CurrentRow.Index].Cells[0].Value.ToString());
                    voPerfil.Descripcion = vPerfil.txtDescripcion.Text;
                    if (Instancia.Modificar(voPerfil))
                    {
                        MessageBox.Show("Modificado correctamente....");
                        llenaGrid();
                        Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Intente nuevamente....");
                    }
                }
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int num = vPerfil.dtPerfiles.RowCount;
            if (num == 0)
            {
                MessageBox.Show("Imposible eliminar!!! tabla sin datos.......");
            }
            else
            {
                if (vPerfil.dtPerfiles.CurrentRow.Selected == false)
                {
                    MessageBox.Show("Seleccione Registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    voPerfil.Id = int.Parse(vPerfil.dtPerfiles.Rows[vPerfil.dtPerfiles.CurrentRow.Index].Cells[0].Value.ToString());
                    if (Instancia.Eliminar(voPerfil))
                    {
                        MessageBox.Show("Eliminado correctamente....");
                        llenaGrid();
                        Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Intente nuevamente....");
                    }
                }
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Doble_Click(object sender, EventArgs e)
        {
            vPerfil.txtPerfil.Enabled = false;
            vPerfil.txtPerfil.Text = vPerfil.dtPerfiles.Rows[vPerfil.dtPerfiles.CurrentRow.Index].Cells[1].Value.ToString();
            vPerfil.txtDescripcion.Text = vPerfil.dtPerfiles.Rows[vPerfil.dtPerfiles.CurrentRow.Index].Cells[2].Value.ToString();
        }



        public void llenaGrid()
        {
            vPerfil.dtPerfiles.DataSource = Instancia.Listar(null);
        }

        public void Refrescar()
        {
            vPerfil.txtPerfil.Enabled = true;
            vPerfil.txtDescripcion.Enabled = true;
            vPerfil.txtPerfil.Clear();
            vPerfil.txtDescripcion.Clear();
            vPerfil.dtPerfiles.ClearSelection();
        }

        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vPerfil.dtPerfiles.ClearSelection();
        }
    }
}
