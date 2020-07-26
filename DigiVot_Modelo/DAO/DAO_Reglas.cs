using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DigiVot_Modelo
{
    public class DAO_Reglas:ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Reglas Reglas;

        public DAO_Reglas()
        {
            cnnConexion = Modelo_Conexion.GetInstancia();
        }

        public bool Eliminar(Object VO)
        {
            Reglas=(VO_Reglas)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_EliminaRegla";
                cmdComando.Parameters.AddWithValue("@idRegla", Reglas.idRegla);
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

        public bool Insertar(Object VO)
        {
            Reglas = (VO_Reglas)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_InsertaRegla";
                cmdComando.Parameters.AddWithValue("@Regla", Reglas.Regla);
                cmdComando.Parameters.AddWithValue("@Descripcion", Reglas.Descripcion);
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

        public bool Modificar(Object VO)
        {
            Reglas = (VO_Reglas)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_ModificaRegla";
                cmdComando.Parameters.AddWithValue("@idRegla", Reglas.idRegla);
                cmdComando.Parameters.AddWithValue("@Descripcion", Reglas.Descripcion);
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

        public List<Object> Listar(Object VO)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                Encabezado();
                cmdComando.CommandText = "sp_ListarReglas";
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> Perfiles = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    VO_Perfiles perfil = new VO_Perfiles();
                    perfil.Id = int.Parse(Dtt.Rows[i][0].ToString());
                    perfil.NombreTipo = Dtt.Rows[i][1].ToString();
                    perfil.Descripcion = Dtt.Rows[i][2].ToString();
                    Perfiles.Add(perfil);
                }
                return Perfiles;
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

        private void Encabezado()
        {
            cmdComando = new SqlCommand();
            cmdComando.Connection = cnnConexion.Conexion;
            cnnConexion.Abrir();
            cmdComando.CommandType = CommandType.StoredProcedure;
        }
    }

}
