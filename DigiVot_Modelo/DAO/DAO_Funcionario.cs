using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class DAO_Funcionario:ICrud
    {
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;
        VO_Funcionarios Funcionario;

        public DAO_Funcionario()
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
            Funcionario = (VO_Funcionarios)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Inserta_TipoRepresentante";
                cmdComando.Parameters.AddWithValue("@Nombre", Funcionario.Funcionario);
                cmdComando.Parameters.AddWithValue("@Descripcion", Funcionario.Descripcion);
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
            Funcionario = (VO_Funcionarios)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Modificar_Funcionario";
                cmdComando.Parameters.AddWithValue("@idFuncionario", Funcionario.idFuncionario);
                cmdComando.Parameters.AddWithValue("@Nombre", Funcionario.Funcionario);
                cmdComando.Parameters.AddWithValue("@Descripcion", Funcionario.Descripcion);
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
            Funcionario = (VO_Funcionarios)VO;
            try
            {
                Encabezado();
                cmdComando.CommandText = "sp_Elimina_Funcionario";
                cmdComando.Parameters.AddWithValue("@idFuncionario", Funcionario.idFuncionario);
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
                cmdComando.CommandText = "sp_Listar_Funcionarios";
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstFuncionarios = new List<Object>();
                for (int i = 0; i < Dtt.Rows.Count; i++)
                {
                    Funcionario = new VO_Funcionarios();
                    Funcionario.idFuncionario = int.Parse(Dtt.Rows[i][0].ToString());
                    Funcionario.Funcionario = Dtt.Rows[i][1].ToString();
                    Funcionario.Descripcion = Dtt.Rows[i][2].ToString();
                    lstFuncionarios.Add(Funcionario);
                }
                return lstFuncionarios;
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
