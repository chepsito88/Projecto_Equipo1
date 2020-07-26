using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class DAO_Login : ICrud
    {

        private SqlCommand cmdComando;
        private SqlDataAdapter daAdapter = null;
        private DataTable Dtt = null;
        Modelo_Conexion cnnConexion;

        public DAO_Login()
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
            VO_User User = (VO_User)VO;
            try
            {
                Dtt = new DataTable();
                Encabezado();
                cmdComando.CommandText = "sp_Login";
                cmdComando.Parameters.AddWithValue("@User", User.Nombre);
                cmdComando.Parameters.AddWithValue("@Password", User.password);
                cmdComando.ExecuteNonQuery();
                daAdapter = new SqlDataAdapter(cmdComando);
                daAdapter.Fill(Dtt);
                List<Object> lstUser = new List<Object>();
                if (Dtt.Rows.Count != 0)
                {
                    VO_User user = new VO_User();
                    user.Nombre = Dtt.Rows[0][0].ToString();
                    user.Puesto = Dtt.Rows[0][1].ToString();
                    user.idUser = int.Parse(Dtt.Rows[0][2].ToString());
                    user.Reglas = Dtt.Rows[0][3].ToString();
                    lstUser.Add(true);
                    lstUser.Add(user);
                }
                else
                {
                    lstUser.Add(false);
                }
                return lstUser;
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

        public bool Modificar(object VO)
        {
            throw new NotImplementedException();
        }
    }
}
