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
    class Controlador_Funcionarios
    {
        Vista_Funcionarios vista_Funcionarios;
        VO_Funcionarios vo_Funcionarios;
        private ICrud InstanciaFuncionarios = Construye_Objeto.intancias(9);
        private Validaciones valida;
        public Controlador_Funcionarios(Vista_Funcionarios vista_Funcionarios, VO_Funcionarios vo_Funcionarios)
        {
            this.vista_Funcionarios = vista_Funcionarios;
            this.vo_Funcionarios = vo_Funcionarios;
            valida = new Validaciones();            
            llenaGrid();
            Evento_Botones();
            vista_Funcionarios.dtgFuncionarios.DataBindingComplete += Limpiar;
        }

        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vista_Funcionarios.dtgFuncionarios.ClearSelection();
        }

        private void Evento_Botones()
        {
            vista_Funcionarios.btnGuardar.Click += Click_Guardar;
            vista_Funcionarios.btnEditar.Click += Click_Modificar;
            vista_Funcionarios.btnEliminar.Click += Click_Eliminar;
            vista_Funcionarios.btnLimpiar.Click += Click_Limpiar;
            vista_Funcionarios.dtgFuncionarios.CellClick += Click_Fila;
        }

        private void Click_Fila(object sender, DataGridViewCellEventArgs e)
        {
            vo_Funcionarios.idFuncionario = int.Parse(vista_Funcionarios.dtgFuncionarios.Rows[vista_Funcionarios.dtgFuncionarios.CurrentRow.Index].Cells[0].Value.ToString());
            vista_Funcionarios.txtNombre.Text = vista_Funcionarios.dtgFuncionarios.Rows[vista_Funcionarios.dtgFuncionarios.CurrentRow.Index].Cells[1].Value.ToString();
            vista_Funcionarios.txtDescripcion.Text = vista_Funcionarios.dtgFuncionarios.Rows[vista_Funcionarios.dtgFuncionarios.CurrentRow.Index].Cells[2].Value.ToString();
        }

        #region Metodos Guardar, Modificar, Eliminar y Listar  
        //Metodo implementado para el almacenamiento de la informacion en la Bds
        private void Click_Guardar(object sender, EventArgs e)
        {
            if (vista_Funcionarios.txtNombre.Text == "" && vista_Funcionarios.txtDescripcion.Text == "")
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Funcionarios.Funcionario = vista_Funcionarios.txtNombre.Text;
                vo_Funcionarios.Descripcion = vista_Funcionarios.txtDescripcion.Text;
                if (InstanciaFuncionarios.Insertar(vo_Funcionarios))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    refrescar();
                    vo_Funcionarios = new VO_Funcionarios();
                }
                else
                {
                    MessageBox.Show("Intente nuevamente....");
                }
            }
        }

       

        //Metodo implementado para la modifiacion de la informacion en la Bds
        private void Click_Modificar(object sender, EventArgs e)
        {
            if (valida.revisaContenidoGrid(vista_Funcionarios.dtgFuncionarios))
            {
                if (valida.revisaSeleccionado(vista_Funcionarios.dtgFuncionarios))
                {
                    vo_Funcionarios.Funcionario = vista_Funcionarios.txtNombre.Text;
                    vo_Funcionarios.Descripcion = vista_Funcionarios.txtDescripcion.Text;
                    if (InstanciaFuncionarios.Modificar(vo_Funcionarios))
                    {
                        llenaGrid();
                        refrescar();
                        MessageBox.Show("Modificado correctamente....");
                    }
                    else
                    {
                        MessageBox.Show("Intente nuevamente....");
                    }

                }
            }
        }

        //Metodo implementado para eliminacion de la informacion en la Bds
        private void Click_Eliminar(object sender, EventArgs e)
        {
            if (valida.revisaSeleccionado(vista_Funcionarios.dtgFuncionarios))
            {
                if (InstanciaFuncionarios.Eliminar(vo_Funcionarios))
                {
                    llenaGrid();
                    refrescar();
                    MessageBox.Show("Eliminado correctamente....");
                }
                else
                {
                    MessageBox.Show("Intente nuevamente....");
                }
            }
        }

        //Metodo implementado para limpiar los controles de la ventana
        private void Click_Limpiar(object sender, EventArgs e)
        {
            refrescar();
        }
        #endregion


        private void llenaGrid()
        {
            List<object> lstFuncionarios = InstanciaFuncionarios.Listar(null);
            if (lstFuncionarios.Count != 0)
            {
                vista_Funcionarios.dtgFuncionarios.DataSource = lstFuncionarios;
                vista_Funcionarios.dtgFuncionarios.Columns[0].Visible = false;
            }
            else
            {
                vista_Funcionarios.dtgFuncionarios.DataSource = "";
            }
        }

        private void refrescar()
        {
            vista_Funcionarios.txtNombre.Clear();
            vista_Funcionarios.txtDescripcion.Clear();
            vo_Funcionarios = new VO_Funcionarios();
        }
    }
}
