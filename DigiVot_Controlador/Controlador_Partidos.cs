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
    class Controlador_Partidos
    {
        VO_Partidos vo_Partidos;
        Vista_Partidos vista_Partidos;
        private ICrud InstanciaPartidos = Construye_Objeto.intancias(6);
        OpenFileDialog ventanImagen;
        Validaciones valida;
        public Controlador_Partidos(Vista_Partidos vista_Partidos, VO_Partidos vo_Partidos)
        {
            this.vista_Partidos = vista_Partidos;
            this.vo_Partidos = vo_Partidos;
            valida = new Validaciones();
            llenaGrid();
            Evento_Botones();
            vista_Partidos.dtgPartidos.DataBindingComplete += Limpiar;
        }

        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vista_Partidos.dtgPartidos.ClearSelection();
        }

        private void Evento_Botones()
        {
            vista_Partidos.btnGuardar.Click += Click_Guardar;
            vista_Partidos.btnEditar.Click += Click_Modificar;
            vista_Partidos.btnEliminar.Click += Click_Eliminar;
            vista_Partidos.btnLimpiar.Click += Click_Limpiar;
            vista_Partidos.btnImagen.Click += Click_Imagen;
            vista_Partidos.dtgPartidos.CellClick += Click_Fila;
        }

        private void Click_Fila(object sender, DataGridViewCellEventArgs e)
        {
            vo_Partidos.id_Partido = int.Parse(vista_Partidos.dtgPartidos.Rows[vista_Partidos.dtgPartidos.CurrentRow.Index].Cells[0].Value.ToString());
            vista_Partidos.txtNombre.Text = vista_Partidos.dtgPartidos.Rows[vista_Partidos.dtgPartidos.CurrentRow.Index].Cells[1].Value.ToString();
            byte[] datos = (byte[])vista_Partidos.dtgPartidos.Rows[vista_Partidos.dtgPartidos.CurrentRow.Index].Cells[2].Value;
            MemoryStream ms = new MemoryStream(datos);
            vista_Partidos.pbxPartido.Image = Bitmap.FromStream(ms);
        }


        #region Metodos Guardar, Modificar, Eliminar y Listar  
        //Metodo implementado para el almacenamiento de la informacion en la Bds
        private void Click_Guardar(object sender, EventArgs e)
        {
            bool verifica = (ventanImagen != null) ? true : false;
            if (vista_Partidos.txtNombre.Text == "" && verifica == false)
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Partidos.Partido = vista_Partidos.txtNombre.Text;
                vo_Partidos.picture = vista_Partidos.pbxPartido;
                if (InstanciaPartidos.Insertar(vo_Partidos))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    refrescar();
                    vo_Partidos = new VO_Partidos();
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
            if (valida.revisaContenidoGrid(vista_Partidos.dtgPartidos))
            {
                if (valida.revisaSeleccionado(vista_Partidos.dtgPartidos))
                {
                    bool verifica = (ventanImagen != null) ? true : false;
                    if (verifica)
                    {
                        vo_Partidos.picture = vista_Partidos.pbxPartido;
                    }
                    vo_Partidos.Partido = vista_Partidos.txtNombre.Text;

                    if (InstanciaPartidos.Modificar(vo_Partidos))
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

        //Metodo implementado para eliminacion de la informacion en la Bds
        private void Click_Eliminar(object sender, EventArgs e)
        {
            if (valida.revisaSeleccionado(vista_Partidos.dtgPartidos))
            {                
                if (InstanciaPartidos.Eliminar(vo_Partidos))
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
            List<object> lstPärtidos = InstanciaPartidos.Listar(null);
            if (lstPärtidos.Count != 0)
            {
                vista_Partidos.dtgPartidos.DataSource = lstPärtidos;
                vista_Partidos.dtgPartidos.Columns[0].Visible = false;
                vista_Partidos.dtgPartidos.Columns[2].Visible = false;
                vista_Partidos.dtgPartidos.Columns[3].Visible = false;
            }
            else
            {
                vista_Partidos.dtgPartidos.DataSource = "";
            }
        }

        #region Herramientas de ventana
        public void refrescar()
        {
            vista_Partidos.txtNombre.Clear();
            vista_Partidos.dtgPartidos.ClearSelection();
            vista_Partidos.pbxPartido.Image = null;
            vo_Partidos = new VO_Partidos();
        }

        private void Click_Imagen(object sender, EventArgs e)
        {
            ventanImagen = new OpenFileDialog();
            DialogResult result = ventanImagen.ShowDialog();
            ventanImagen.Title = "Selecione el achivo adecuado";
            ventanImagen.Filter = "Archivos (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            ventanImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (result == DialogResult.OK)
            {
                vista_Partidos.pbxPartido.Load(ventanImagen.FileName);
            }
            else if (result == DialogResult.Cancel)
            {

                MessageBox.Show("Revisar");
            }
        }

        #endregion
    }
}
