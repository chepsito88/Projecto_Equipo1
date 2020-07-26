using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    class Modelo_Conexion
    {
        private static Modelo_Conexion Instancia = null;
        private static readonly object Padlock = new object();
        public SqlConnection Conexion;

        private Modelo_Conexion()
        {
            lock (Padlock)
            {
                //Conexion = new SqlConnection(@"Data Source=Gabino; database=Bd_Elecciones;User Id=sa; Password=GabinoHH");//modifica
                Conexion = new SqlConnection(@"Data Source=DESKTOP-GL2L3IJ; database=Bd_Elecciones;User Id=sa; Password=chepsito");
            }
        }

        public static Modelo_Conexion GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Modelo_Conexion();
            }
            return Instancia;
        }

        public void Abrir()
        {
            if (Instancia != null)
                Conexion.Open();
        }

        public void Cerrar()
        {
            if (Instancia != null)
                Conexion.Close();
        }
    }
}
