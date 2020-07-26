using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class DAO_PerfilReglas:ICrud
    {

        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;       
        VO_PerfilReglas PerfilReglas;


        public DAO_PerfilReglas()
        {
            cnnConexion = Modelo_Conexion.GetInstancia();
        }

        public bool Eliminar(object VO)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(object VO)
        {
            PerfilReglas = (VO_PerfilReglas)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_InsertaPerfilRegla";
                cmdComando.Parameters.AddWithValue("@idReglas", PerfilReglas.Regla);
                cmdComando.Parameters.AddWithValue("@idPerfil", PerfilReglas.idPerfil);
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
            VO_Perfiles Perfil = (VO_Perfiles)VO;
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                Encabezado();
                cmdComando.CommandText = "sp_ListarPerfilReglas";
                cmdComando.Parameters.AddWithValue("@idPerfil", Perfil.Id);
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstPerfiles = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    VO_PerfilReglas perfilReglas = new VO_PerfilReglas();
                    perfilReglas.Selected =(bool) Dtt.Rows[i][0];
                    perfilReglas.id=int.Parse(Dtt.Rows[i][1].ToString());
                    perfilReglas.Regla = Dtt.Rows[i][2].ToString();
                    lstPerfiles.Add(perfilReglas);
                }

                return lstPerfiles;
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

        private void Encabezado()
        {
            cmdComando = new SqlCommand();
            cmdComando.Connection = cnnConexion.Conexion;
            cnnConexion.Abrir();
            cmdComando.CommandType = CommandType.StoredProcedure;
        }
    }
}
