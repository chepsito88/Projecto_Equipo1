using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiVot_Controlador
{
    class Validaciones
    {
        public bool revisaContenidoGrid(DataGridView data)
        {
            int num = data.RowCount;
            if (num == 0)
            {
                MessageBox.Show("Imposible modificar!!! tabla sin datos.......");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool revisaSeleccionado(DataGridView data)
        {
            if (data.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione Registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validaModificacion(int idEleccion, int idPartido,bool verifica){
            if (idEleccion == -1 && idPartido == -1 && verifica!=true)
            {
                MessageBox.Show("Modifique al menos un dato.....");
                return false;
            }else {
                return true;
            }
        }

        public bool validaModificacionPartido(string Partido, bool verifica)
        {
            if (Partido==string.Empty && verifica != true)
            {
                MessageBox.Show("Datos necesarios.....");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
