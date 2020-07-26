using System;
using System.Collections.Generic;
using DigiVot_Vista;
using DigiVot_Modelo;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace DigiVot_Controlador
{
    class Controlador_Candidato
    {
        Vista_Candidato vista_Candidato;
        VO_Candidato vo_Candidato;
        VO_Ciudadano vo_Ciudadano;
        VO_Partidos vo_Partidos;
        private ICrud InstanciaPartidos = Construye_Objeto.intancias(6);
        private ICrud InstanciaCandidatos = Construye_Objeto.intancias(5);
        private ICrud InstanciaCiudadanos = Construye_Objeto.intancias(7);
        private ICrud InstanciaElecciones = Construye_Objeto.intancias(8);
        OpenFileDialog abrir;
        private Validaciones valida;
        public Controlador_Candidato(Vista_Candidato vista_Candidato, VO_Candidato vo_Candidato, VO_Partidos vo_Partidos, VO_Ciudadano vo_Ciudadano)
        {
            this.vista_Candidato = vista_Candidato;
            this.vo_Candidato = vo_Candidato;
            this.vo_Partidos = vo_Partidos;
            this.vo_Ciudadano = vo_Ciudadano;
            valida = new Validaciones();
            cargaInicial();
            Eventos_Botones();
            llenaGrid();
            vista_Candidato.dtgListaCandidatos.DataBindingComplete += Limpiar;

        }

        private void Limpiar(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            vista_Candidato.dtgListaCandidatos.ClearSelection();
        }

        private void Eventos_Botones()
        {
            vista_Candidato.btnAgregarImagen.Click += Click_AgregarImagen;
            vista_Candidato.btnBuscar.Click += Click_Buscar;
            vista_Candidato.btnGuardar.Click += Click_Guardar;
            vista_Candidato.btnLimpiar.Click += Click_Limpiar;
            vista_Candidato.btnEliminar.Click += Click_Eliminar;
            vista_Candidato.btnEditar.Click += Click_Modificar;
            vista_Candidato.cmbPartidoAsign.Click += Click_ComboPartido;
            vista_Candidato.cmbEleccionAsign.Click += Click_ComboElecciones;
            vista_Candidato.dtgListaCandidatos.CellClick += Click_Doble;

        }

        private void Click_ComboElecciones(object sender, EventArgs e)
        {
            CargarTipoEleccion();
        }

        private void Click_ComboPartido(object sender, EventArgs e)
        {
            CargarPartidos();
        }

        private void Click_Doble(object sender, DataGridViewCellEventArgs e)
        {
            vista_Candidato.cmbEleccionAsign.DataSource = null;
            vista_Candidato.cmbPartidoAsign.DataSource = null;
            vista_Candidato.cmbEleccionAsign.Items.Clear();
            vista_Candidato.cmbPartidoAsign.Items.Clear();
            vista_Candidato.cmbEleccionAsign.Items.Insert(0, vista_Candidato.dtgListaCandidatos.Rows[vista_Candidato.dtgListaCandidatos.CurrentRow.Index].Cells[6].Value.ToString());
            vista_Candidato.cmbPartidoAsign.Items.Insert(0, vista_Candidato.dtgListaCandidatos.Rows[vista_Candidato.dtgListaCandidatos.CurrentRow.Index].Cells[4].Value.ToString());
            vista_Candidato.cmbPartidoAsign.SelectedIndex = 0;
            vista_Candidato.cmbEleccionAsign.SelectedIndex = 0;
            vista_Candidato.txtCurp.Enabled = false;
            vista_Candidato.btnBuscar.Enabled = false;
            vista_Candidato.btnGuardar.Enabled = false;
            vista_Candidato.txtCurp.Text = vista_Candidato.dtgListaCandidatos.Rows[vista_Candidato.dtgListaCandidatos.CurrentRow.Index].Cells[0].Value.ToString();
            vista_Candidato.txtNombre.Text = vista_Candidato.dtgListaCandidatos.Rows[vista_Candidato.dtgListaCandidatos.CurrentRow.Index].Cells[1].Value.ToString();
            vista_Candidato.txtApellidoP.Text = vista_Candidato.dtgListaCandidatos.Rows[vista_Candidato.dtgListaCandidatos.CurrentRow.Index].Cells[2].Value.ToString();
            vista_Candidato.txtApellidoM.Text = vista_Candidato.dtgListaCandidatos.Rows[vista_Candidato.dtgListaCandidatos.CurrentRow.Index].Cells[3].Value.ToString();
            vista_Candidato.cmbPartidoAsign.SelectedValue = int.Parse(vista_Candidato.dtgListaCandidatos.Rows[vista_Candidato.dtgListaCandidatos.CurrentRow.Index].Cells[5].Value.ToString());
            byte[]datos=(byte[]) vista_Candidato.dtgListaCandidatos.Rows[vista_Candidato.dtgListaCandidatos.CurrentRow.Index].Cells[8].Value;
            MemoryStream ms = new MemoryStream(datos);
            vista_Candidato.ptbImagenCandidato.Image = Bitmap.FromStream(ms);            
        }

        private void Click_Modificar(object sender, EventArgs e)
        {
            if (valida.revisaContenidoGrid(vista_Candidato.dtgListaCandidatos))
            {
                if (valida.revisaSeleccionado(vista_Candidato.dtgListaCandidatos))
                {
                    bool verifica = (abrir != null) ? true : false;
                    if (verifica)
                    {
                        vo_Candidato.picture = vista_Candidato.ptbImagenCandidato;
                    }
                    vo_Candidato.Curp = vista_Candidato.txtCurp.Text;
                    vo_Candidato.IdEleccion = (vista_Candidato.cmbEleccionAsign.SelectedValue != null) ? int.Parse(vista_Candidato.cmbEleccionAsign.SelectedValue.ToString()) : -1;
                    vo_Candidato.IdPartido = (vista_Candidato.cmbPartidoAsign.SelectedValue != null) ? int.Parse(vista_Candidato.cmbPartidoAsign.SelectedValue.ToString()) : -1;
                    if (valida.validaModificacion(vo_Candidato.IdEleccion, vo_Candidato.IdPartido,verifica))
                    {
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
        }

        //Metodo empleado para la eliminacion de un registro
        private void Click_Eliminar(object sender, EventArgs e)
        {
            if (valida.revisaContenidoGrid(vista_Candidato.dtgListaCandidatos))
            {
                if (valida.revisaSeleccionado(vista_Candidato.dtgListaCandidatos))
                {
                    vo_Candidato.Curp = vista_Candidato.txtCurp.Text;
                    
                    vista_Candidato.ptbImagenCandidato.Image.Dispose();
                    if (InstanciaCandidatos.Eliminar(vo_Candidato))
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
        }

        private void Click_Limpiar(object sender, EventArgs e)
        {
            refrescar();
        }


        private void Click_Guardar(object sender, EventArgs e)
        {
            if (vista_Candidato.txtCurp.Text == "" )
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Candidato.Curp = vista_Candidato.txtCurp.Text;
                vo_Candidato.IdPartido = int.Parse(vista_Candidato.cmbPartidoAsign.SelectedValue.ToString());
                vo_Candidato.IdEleccion = int.Parse(vista_Candidato.cmbEleccionAsign.SelectedValue.ToString());
                vo_Candidato.picture = vista_Candidato.ptbImagenCandidato;
                if (InstanciaCandidatos.Insertar(vo_Candidato))
                {
                    MessageBox.Show("Almacenado correctamente....");
                    llenaGrid();
                    refrescar();
                    vo_Candidato = new VO_Candidato();
                }
                else
                {
                    MessageBox.Show("Intente nuevamente....");
                }
            }
        }

        //Metodo que se encarga de buscar si en BDs existe el registro de un ciudadano
        private void Click_Buscar(object sender, EventArgs e)
        {
            if (vista_Candidato.txtCurp.Text == string.Empty)
            {
                MessageBox.Show("Campos requeridos obligatoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                vo_Ciudadano.Curp = vista_Candidato.txtCurp.Text;
                List<Object> lstCiudadano = InstanciaCiudadanos.Listar(vo_Ciudadano);
                if (lstCiudadano.Count > 0)
                {
                    vo_Ciudadano = (VO_Ciudadano)lstCiudadano[0];
                    vista_Candidato.txtNombre.Text = vo_Ciudadano.Nombre;
                    vista_Candidato.txtApellidoP.Text = vo_Ciudadano.APaterno;
                    vista_Candidato.txtApellidoM.Text = vo_Ciudadano.AMaterno;
                    vista_Candidato.btnEditar.Enabled = false;
                    vista_Candidato.btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No existe registros...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        #region Carga de Controles

        //Metodo que permite inicializar los combos con el texto de Elejir (neceario al cargar desde un Datasource)
        public void cargaInicial()
        {
            vista_Candidato.cmbEleccionAsign.DataSource = null;
            vista_Candidato.cmbPartidoAsign.DataSource = null;
            vista_Candidato.cmbEleccionAsign.Items.Clear();
            vista_Candidato.cmbPartidoAsign.Items.Clear();
            vista_Candidato.cmbEleccionAsign.Items.Add("Elije");
            vista_Candidato.cmbEleccionAsign.SelectedIndex = 0;
            vista_Candidato.cmbPartidoAsign.Items.Add("Elije");
            vista_Candidato.cmbPartidoAsign.SelectedIndex = 0;
        }
        //Metodo que se encarga del llenado del Grid que muestra los candidatos 
        public void llenaGrid()
        {
            List<object> lstCandidatos = InstanciaCandidatos.Listar(null);
            if (lstCandidatos.Count != 0)
            {
                vista_Candidato.dtgListaCandidatos.DataSource = lstCandidatos;
                vista_Candidato.dtgListaCandidatos.Columns[5].Visible = false;
                vista_Candidato.dtgListaCandidatos.Columns[7].Visible = false;
                vista_Candidato.dtgListaCandidatos.Columns[8].Visible = false;
                vista_Candidato.dtgListaCandidatos.Columns[9].Visible = false;

            }
            else {
                vista_Candidato.dtgListaCandidatos.DataSource ="";
            }
        }

        //Metodo que permite cargar el combo de partidos (a través de un DataSource)
        private void CargarPartidos()
        {
            vista_Candidato.cmbPartidoAsign.ValueMember = "Id_Partido";
            vista_Candidato.cmbPartidoAsign.DisplayMember = "Partido";
            List<object> lstPartidos = InstanciaPartidos.Listar(null);
            if (lstPartidos.Count != 0)
            {
                vista_Candidato.cmbPartidoAsign.DataSource = lstPartidos;
            }
            else
            {
                MessageBox.Show("Favor de agregar Partidos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Metodo que permite cargar el combo de Tipos de elecciones (a través de un DataSource)
        private void CargarTipoEleccion()
        {
            vista_Candidato.cmbEleccionAsign.ValueMember = "Id_Eleccion";
            vista_Candidato.cmbEleccionAsign.DisplayMember = "Eleccion";
            List<object> lstElecciones = InstanciaElecciones.Listar(null);
            if (lstElecciones.Count != 0)
            {
                vista_Candidato.cmbEleccionAsign.DataSource = lstElecciones;
            }
            else {
                MessageBox.Show("Favor de agregar Elecciones...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        #endregion

        #region Herramientas de la ventana
        
        //Metodo que refresca los controles
        public void refrescar()
        {
            vista_Candidato.txtCurp.Enabled = true;
            vista_Candidato.btnBuscar.Enabled = true;
            vista_Candidato.btnGuardar.Enabled = true;
            vista_Candidato.btnAgregarImagen.Enabled = true;
            vista_Candidato.btnEditar.Enabled = true;
            vista_Candidato.btnEliminar.Enabled = true;
            vista_Candidato.txtCurp.Clear();
            vista_Candidato.txtNombre.Clear();
            vista_Candidato.txtApellidoP.Clear();
            vista_Candidato.txtApellidoM.Clear();
            vista_Candidato.dtgListaCandidatos.ClearSelection();
            vista_Candidato.ptbImagenCandidato.Image = null;           
            cargaInicial();
            vo_Candidato = new VO_Candidato();
        }

        //Metodo empleado para abrir una imagen 
        private void Click_AgregarImagen(object sender, EventArgs e)
        {
            abrir = new OpenFileDialog();
            DialogResult result = abrir.ShowDialog();
            abrir.Title = "Selecione el achivo adecuado";
            abrir.Filter = "Archivos (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (result == DialogResult.OK)
            {
                vista_Candidato.ptbImagenCandidato.Load(abrir.FileName);
            }
            else if (result == DialogResult.Cancel)
            {

                MessageBox.Show("Revisar");
            }
        }
        #endregion

    }
}
