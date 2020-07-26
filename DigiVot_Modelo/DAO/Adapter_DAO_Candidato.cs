using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DigiVot_Modelo
{
    public class Adapter_DAO_Candidato : ICrud
    {
        private DAO_Candidato _DAO_Candidato;
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Candidato Candidato;
        
        public Adapter_DAO_Candidato()
        {
            cnnConexion = Modelo_Conexion.GetInstancia();
            _DAO_Candidato = new DAO_Candidato();

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
            Candidato = (VO_Candidato)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "[sp_Inserta_Candidato]";
                cmdComando.Parameters.AddWithValue("@Curp", Candidato.Curp);
                cmdComando.Parameters.AddWithValue("@Partido", Candidato.IdPartido);
                cmdComando.Parameters.AddWithValue("@Eleccion", Candidato.IdEleccion);
                cmdComando.Parameters.Add("@Foto", SqlDbType.Image);
                MemoryStream ms = new MemoryStream();
                Candidato.picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmdComando.Parameters["@Foto"].Value = ms.GetBuffer();
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
            Candidato = (VO_Candidato)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Modificar_Candidato";
                cmdComando.Parameters.AddWithValue("@Curp", Candidato.Curp);
                cmdComando.Parameters.AddWithValue("@IdPartido", Candidato.IdPartido);
                cmdComando.Parameters.AddWithValue("@IdEleccion", Candidato.IdEleccion);
                if (Candidato.picture != null)
                {
                    cmdComando.Parameters.Add("@Foto", SqlDbType.Image);
                    MemoryStream ms = new MemoryStream();
                    Candidato.picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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
            Candidato = (VO_Candidato)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Eliminar_Candidato";
                cmdComando.Parameters.AddWithValue("@Curp", Candidato.Curp);
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
                cmdComando.CommandText = "sp_Listar_Candidatos";
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstElecciones = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    VO_Candidato candidato = new VO_Candidato();
                    candidato.Curp = Dtt.Rows[i][0].ToString();
                    candidato.Nombre = Dtt.Rows[i][1].ToString();
                    candidato.APaterno = Dtt.Rows[i][2].ToString();
                    candidato.AMaterno = Dtt.Rows[i][3].ToString();
                    candidato.Partido = Dtt.Rows[i][4].ToString();
                    candidato.IdPartido = int.Parse(Dtt.Rows[i][5].ToString());
                    candidato.Eleccion = Dtt.Rows[i][6].ToString();
                    candidato.IdEleccion = int.Parse(Dtt.Rows[i][7].ToString());
                    byte[] datos = new byte[0];                    
                    datos = (byte[])Dtt.Rows[i][8];
                    candidato.datos = datos;
                    lstElecciones.Add(candidato);
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
