using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DigiVot_Modelo
{
    public class DAO_Ciudadano:ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Ciudadano Ciudadano;

        public DAO_Ciudadano()
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
            VO_Ciudadano ciudadano = (VO_Ciudadano)VO;
            try
            {
                Dtt = new DataTable();
                Encabezado();
                cmdComando.CommandText = "sp_Listar_CiudadanoPorCurp";
                cmdComando.Parameters.AddWithValue("@Curp", ciudadano.Curp);
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstCiudadano = new List<Object>();
                if (Dtt.Rows.Count != 0)
                {
                    VO_Ciudadano Ciudadano = new VO_Ciudadano();
                    Ciudadano.Curp = Dtt.Rows[0][0].ToString();
                    Ciudadano.Nombre = Dtt.Rows[0][1].ToString();
                    Ciudadano.APaterno = Dtt.Rows[0][2].ToString();
                    Ciudadano.AMaterno = Dtt.Rows[0][3].ToString();
                    Ciudadano.Edad = int.Parse(Dtt.Rows[0][4].ToString());
                    Ciudadano.Sexo = Dtt.Rows[0][5].ToString();
                    Ciudadano.Vigencia = Dtt.Rows[0][6].ToString();
                    Ciudadano.Direccion = int.Parse(Dtt.Rows[0][7].ToString());
                    lstCiudadano.Add(true);
                    lstCiudadano.Add(Ciudadano);
                }
                else
                {
                    lstCiudadano.Add(false);
                }
                return lstCiudadano;
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
