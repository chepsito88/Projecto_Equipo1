using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class DAO_Elecciones : ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Tipo_Eleccion tipo_Eleccion;

        public DAO_Elecciones()
        {
            cnnConexion = Modelo_Conexion.GetInstancia();
        }

        private void Encabezado()
        {
            cmdComando = new SqlCommand();
            cmdComando.Connection = cnnConexion.Conexion;
            cnnConexion.Abrir();
            cmdComando.CommandType = CommandType.StoredProcedure;
        }

       
        public bool Insertar(object VO)
        {
            tipo_Eleccion = (VO_Tipo_Eleccion)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Inserta_Eleccion";
                cmdComando.Parameters.AddWithValue("@Nombre", tipo_Eleccion.Eleccion);
                cmdComando.Parameters.AddWithValue("@Descripcion", tipo_Eleccion.Descripcion);                
                cmdComando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: "+ e);
                return false;
            }
            finally
            {
                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }

        public bool Modificar(object VO)
        {
            tipo_Eleccion = (VO_Tipo_Eleccion)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Modificar_Eleccion";
                cmdComando.Parameters.AddWithValue("@idEleccion",tipo_Eleccion.id_Eleccion);
                cmdComando.Parameters.AddWithValue("@Nombre", tipo_Eleccion.Eleccion);
                cmdComando.Parameters.AddWithValue("@Descripcion", tipo_Eleccion.Descripcion);
                cmdComando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e);
                return false;
            }
            finally
            {

                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }
        public bool Eliminar(object VO)
        {
            tipo_Eleccion = (VO_Tipo_Eleccion)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Eliminar_Eleccion";
                cmdComando.Parameters.AddWithValue("@idEleccion", tipo_Eleccion.id_Eleccion);
                cmdComando.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e);
                return false;
            }
            finally
            {

                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }

        public List<object> Listar(object VO)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                Encabezado();
                cmdComando.CommandText = "sp_Listar_TipoElecciones";
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstElecciones = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    VO_Tipo_Eleccion Eleccion = new VO_Tipo_Eleccion();
                    Eleccion.id_Eleccion = int.Parse(Dtt.Rows[i][0].ToString());
                    Eleccion.Eleccion = Dtt.Rows[i][1].ToString();
                    Eleccion.Descripcion = Dtt.Rows[i][2].ToString();
                    lstElecciones.Add(Eleccion);
                }
                return lstElecciones;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e);
                return null;
            }
            finally
            {
                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }           
    }
}
