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
    class DAO_Partidos : ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Partidos Partido;

        public DAO_Partidos()
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
            Partido = (VO_Partidos)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Inserta_Partido";
                cmdComando.Parameters.AddWithValue("@NombrePartido", Partido.Partido);                         
                cmdComando.Parameters.Add("@FotoPartido", SqlDbType.Image);
                MemoryStream ms = new MemoryStream();
                Partido.picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmdComando.Parameters["@FotoPartido"].Value = ms.GetBuffer();
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


        public bool Modificar(object VO)
        {
            Partido = (VO_Partidos)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Modificar_Partido";
                cmdComando.Parameters.AddWithValue("@idPartido", Partido.id_Partido);
                cmdComando.Parameters.AddWithValue("@Nombre", Partido.Partido);                
                if (Partido.picture != null)
                {
                    cmdComando.Parameters.Add("@Foto", SqlDbType.Image);
                    MemoryStream ms = new MemoryStream();
                    Partido.picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    cmdComando.Parameters["@Foto"].Value = ms.GetBuffer();
                }
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
            Partido = (VO_Partidos)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Eliminar_Partido";
                cmdComando.Parameters.AddWithValue("@idPartido", Partido.id_Partido);
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
                cmdComando.CommandText = "sp_Listar_Partidos";
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstPartidos = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    VO_Partidos Partido = new VO_Partidos();
                    Partido.id_Partido =int.Parse(Dtt.Rows[i][0].ToString());
                    Partido.Partido = Dtt.Rows[i][1].ToString();
                    byte[] datos = new byte[0];
                    datos = (byte[])Dtt.Rows[i][2];
                    Partido.datos = datos;
                    lstPartidos.Add(Partido);
                }

                return lstPartidos;
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
