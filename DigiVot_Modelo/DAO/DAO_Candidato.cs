using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DigiVot_Modelo
{
    public class DAO_Candidato : ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Candidato Candidato;
        

        public DAO_Candidato()
        {
            cnnConexion = Modelo_Conexion.GetInstancia();
        }

        public bool Eliminar(object VO)
        {
            //Candidato = (VO_Candidato)VO;
            //try
            //{
            //    Encabezado();
            //    cmdComando.CommandText = "sp_EliminarCandidato";
            //    cmdComando.Parameters.AddWithValue("@idRegla", Candidato.idCandidato);
            //    cmdComando.ExecuteNonQuery();
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    return false;
            //}
            //finally
            //{

            //    cnnConexion.Cerrar();
            //    cmdComando.Dispose();
            //}
            throw new NotImplementedException();
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
                cmdComando.Parameters.AddWithValue("@Foto", Candidato.Foto);
                cmdComando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
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
                    candidato.Partido = Dtt.Rows[i][2].ToString();
                    candidato.IdPartido = int.Parse(Dtt.Rows[i][3].ToString());
                    candidato.Eleccion = Dtt.Rows[i][4].ToString();
                    candidato.IdEleccion = int.Parse(Dtt.Rows[i][5].ToString());
                    candidato.Foto = Dtt.Rows[i][6].ToString();
                    lstElecciones.Add(candidato);
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
