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
    class Controlador_Reglas
    {
        private Vista_Reglas vReglas;
        private VO_Reglas voReglas;
        private ICrud Instancia = Construye_Objeto.intancias(2);
        object VO;


        public Controlador_Reglas(Vista_Reglas vReglas, VO_Reglas voReglas)
        {
            this.vReglas = vReglas;
            this.voReglas = voReglas;
            vReglas.btnGuardar.Click += Guardar_Click;
            vReglas.dtReglas.CellDoubleClick += Doble_Click;
            vReglas.btnEditar.Click += Modificar_Click;
            vReglas.btnEliminar.Click += Eliminar_Click;
            vReglas.btnLimpiar.Click += Limpiar_Click;
            llenaGrid();
            vReglas.dtReglas.Columns[0].Visible = false;
            vReglas.dtReglas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vReglas.dtReglas.DataBindingComplete += Limpiar;

        }



        private void Guardar_Click(object sender, EventArgs e)
        {

            if (vReglas.txtRegla.Text == "" && vReglas.txtDescripcion.Text == "")
            {
                MessageBox.Show("Campos requeridos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                voReglas.Regla = vReglas.txtRegla.Text;
                voReglas.Descripcion = vReglas.txtDescripcion.Text;
                VO = voReglas;
                if (Instancia.Insertar(VO))
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
            int num = vReglas.dtReglas.RowCount;
            if (num == 0)
            {
                MessageBox.Show("Imposible modificar!!! tabla sin datos.......");
            }
            else
            {
                if (vReglas.dtReglas.CurrentRow.Selected == false)
                {
                    MessageBox.Show("Seleccione Registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    voReglas.idRegla = int.Parse(vReglas.dtReglas.Rows[vReglas.dtReglas.CurrentRow.Index].Cells[0].Value.ToString());
                    voReglas.Descripcion = vReglas.txtDescripcion.Text;
                    VO = voReglas;
                    if (Instancia.Modificar(VO))
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
            int num = vReglas.dtReglas.RowCount;
            if (num == 0)
            {
                MessageBox.Show("Imposible eliminar!!! tabla sin datos.......");
            }
            else
            {
                if (vReglas.dtReglas.CurrentRow.Selected == false)
                {
                    MessageBox.Show("Seleccione Registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    voReglas.idRegla = int.Parse(vReglas.dtReglas.Rows[vReglas.dtReglas.CurrentRow.Index].Cells[0].Value.ToString());
                    VO = voReglas;
                    if (Instancia.Eliminar(VO))
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
            vReglas.txtRegla.Enabled = false;
            vReglas.txtRegla.Text = vReglas.dtReglas.Rows[vReglas.dtReglas.CurrentRow.Index].Cells[1].Value.ToString();
            vReglas.txtDescripcion.Text = vReglas.dtReglas.Rows[vReglas.dtReglas.CurrentRow.Index].Cells[2].Value.ToString();
        }



        public void llenaGrid()
        {
            vReglas.dtReglas.DataSource = Instancia.Listar(null);
        }

        public void Refrescar()
        {
            vReglas.txtRegla.Enabled = true;
            vReglas.txtDescripcion.Enabled = true;
            vReglas.txtRegla.Clear();
            vReglas.txtDescripcion.Clear();
            vReglas.dtReglas.ClearSelection();
        }

        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vReglas.dtReglas.ClearSelection();
        }
    }
}
