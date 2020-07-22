using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DigiVot_Modelo
{
    public class DAO_Elecciones:ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Elecciones Eleccion;

        public DAO_Elecciones()
        {
            cnnConexion = Modelo_Conexion.GetInstancia();
        }

        public bool Eliminar(object VO)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(object VO)
        {
            throw new NotImplementedException();
        }

        public List<object> Listar(object VO)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                Encabezado();
                cmdComando.CommandText = "sp_Listar_TipoELecciones";
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstElecciones = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    VO_Elecciones eleccion = new VO_Elecciones();
                    eleccion.Id = int.Parse(Dtt.Rows[i][0].ToString());
                    eleccion.Nombre = Dtt.Rows[i][1].ToString();
                    lstElecciones.Add(eleccion);
                }

                return lstElecciones;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }

        public bool Modificar(object VO)
        {
            throw new NotImplementedException();
        }

        private void Encabezado()
        {
            cmdComando = new SqlCommand();
            cmdComando.Connection = cnnConexion.Conexion;
            cnnConexion.Abrir();
            cmdComando.CommandType = CommandType.StoredProcedure;
        }
    }
}
