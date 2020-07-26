using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class DAO_Ciudadano : ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Ciudadano vo_Ciudadano;

        public DAO_Ciudadano()
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
                cmdComando.CommandText = "sp_Listar_Ciudadano";
                if (VO!=null)
                {
                    vo_Ciudadano = (VO_Ciudadano)VO;
                    cmdComando.Parameters.AddWithValue("@Curp", vo_Ciudadano.Curp);
                }
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstCiudadanos = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    vo_Ciudadano.Curp= Dtt.Rows[i][0].ToString();
                    vo_Ciudadano.Nombre = Dtt.Rows[i][1].ToString();
                    vo_Ciudadano.APaterno = Dtt.Rows[i][2].ToString();
                    vo_Ciudadano.AMaterno = Dtt.Rows[i][3].ToString();
                    lstCiudadanos.Add(vo_Ciudadano);
                }
                return lstCiudadanos;
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

        public bool Modificar(object VO)
        {
            throw new NotImplementedException();
        }
    }
}
