using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiVot_Modelo;
using DigiVot_Vista;

namespace DigiVot_Controlador
{
    class Controlador_Elecciones
    {
        VO_Tipo_Eleccion vo_Elecciones;
        Vista_Tipo_Elecciones vista_Elecciones;
        private ICrud InstanciaElecciones = Construye_Objeto.intancias(8);        
        Validaciones valida;
        public Controlador_Elecciones(Vista_Tipo_Elecciones vista_Elecciones, VO_Tipo_Eleccion vo_Elecciones)
        {
            this.vista_Elecciones = vista_Elecciones;
            this.vo_Elecciones = vo_Elecciones;
            valida = new Validaciones();            
            llenaGrid();
            Evento_Botones();
            vista_Elecciones.dtgEleciones.DataBindingComplete += Limpiar;
        }

        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vista_Elecciones.dtgEleciones.ClearSelection();
        }

        private void Evento_Botones()
        {
            vista_Elecciones.btnGuardar.Click += Click_Guardar;
            vista_Elecciones.btnEditar.Click += Click_Modificar;
            vista_Elecciones.btnEliminar.Click += Click_Eliminar;
            vista_Elecciones.btnLimpiar.Click += Click_Limpiar;
            vista_Elecciones.dtgEleciones.CellClick += Click_Fila;
        }

        private void Click_Fila(object sender, DataGridViewCellEventArgs e)
        {
            vo_Elecciones.id_Eleccion= int.Parse(vista_Elecciones.dtgEleciones.Rows[vista_Elecciones.dtgEleciones.CurrentRow.Index].Cells[0].Value.ToString());
            vista_Elecciones.txtNombre.Text = vista_Elecciones.dtgEleciones.Rows[vista_Elecciones.dtgEleciones.CurrentRow.Index].Cells[1].Value.ToString();
            vista_Elecciones.txtDescripcion.Text = vista_Elecciones.dtgEleciones.Rows[vista_Elecciones.dtgEleciones.CurrentRow.Index].Cells[2].Value.ToString();
        }

        #region Metodos Guardar, Modificar, Eliminar y Listar  
        //Metodo implementado para el almacenamiento de la informacion en la Bds
        private void Click_Guardar(object sender, EventArgs e)
        {            
            if (vista_Elecciones.txtNombre.Text == "" && vista_Elecciones.txtDescripcion.Text=="")
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Elecciones.Eleccion = vista_Elecciones.txtNombre.Text;
                vo_Elecciones.Descripcion = vista_Elecciones.txtDescripcion.Text;
                if (InstanciaElecciones.Insertar(vo_Elecciones))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    refrescar();
                    vo_Elecciones = new VO_Tipo_Eleccion();
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
            if (valida.revisaContenidoGrid(vista_Elecciones.dtgEleciones))
            {
                if (valida.revisaSeleccionado(vista_Elecciones.dtgEleciones))
                {                   
                    vo_Elecciones.Eleccion = vista_Elecciones.txtNombre.Text;
                    vo_Elecciones.Descripcion = vista_Elecciones.txtDescripcion.Text;
                    if (InstanciaElecciones.Modificar(vo_Elecciones))
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
            if (valida.revisaSeleccionado(vista_Elecciones.dtgEleciones))
            {
                if (InstanciaElecciones.Eliminar(vo_Elecciones))
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
            List<object> lstElecciones = InstanciaElecciones.Listar(null);
            if (lstElecciones.Count != 0)
            {
                vista_Elecciones.dtgEleciones.DataSource = lstElecciones;
                vista_Elecciones.dtgEleciones.Columns[0].Visible = false;
            }
            else
            {
                vista_Elecciones.dtgEleciones.DataSource = "";
            }
        }

        private void refrescar()
        {
            vista_Elecciones.txtNombre.Clear();
            vista_Elecciones.txtDescripcion.Clear();
            vo_Elecciones = new VO_Tipo_Eleccion();
        }

    }
}
