using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DigiVot_Modelo
{
    public class DAO_Perfiles:ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Perfiles Perfil;


        public DAO_Perfiles()
        {
            cnnConexion = Modelo_Conexion.GetInstancia();
        }

        public bool Eliminar(Object VO)
        {
            Perfil = (VO_Perfiles)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_EliminarPerfil";
                cmdComando.Parameters.AddWithValue("@Id", Perfil.Id);
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

        public bool Insertar(Object VO) {
            Perfil = (VO_Perfiles)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Inserta_TipoRepresentante";
                cmdComando.Parameters.AddWithValue("@Nombre", Perfil.NombreTipo);
                cmdComando.Parameters.AddWithValue("@Descripcion", Perfil.Descripcion);
                cmdComando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                System.Windows.Forms.MessageBox.Show("Error: " + e);
                return false;
            }
            finally {

                cnnConexion.Cerrar();
                cmdComando.Dispose();
            }
        }

        public bool Modificar(Object VO)
        {
            Perfil =(VO_Perfiles) VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_ModificaPerfi";
                cmdComando.Parameters.AddWithValue("@Id", Perfil.Id);
                cmdComando.Parameters.AddWithValue("@Descripcion", Perfil.Descripcion);
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
                cmdComando.CommandText = "sp_Listar_Perfiles";
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstPerfiles = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    VO_Perfiles perfil = new VO_Perfiles();
                    perfil.Id =int.Parse(Dtt.Rows[i][0].ToString());
                    perfil.NombreTipo = Dtt.Rows[i][1].ToString();
                    perfil.Descripcion = Dtt.Rows[i][2].ToString();                    
                    lstPerfiles.Add(perfil);                    
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
     
        private void Encabezado()
        {
            cmdComando = new SqlCommand();
            cmdComando.Connection = cnnConexion.Conexion;
            cnnConexion.Abrir();
            cmdComando.CommandType = CommandType.StoredProcedure;
        }      
    }

}
