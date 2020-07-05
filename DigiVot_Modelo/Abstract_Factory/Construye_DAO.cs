using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    public class Construye_Objeto
    {
        public static ICrud intancias (int Opc) {
            switch (Opc)
            {
                case 1:return new DAO_Perfiles();
                case 2:return new DAO_Reglas();
                case 3:return new DAO_PerfilReglas();
                case 4: return new DAO_Login();
                default: return null;
            }
        }
    }
}
