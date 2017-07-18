using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiVot_Vista;
using DigiVot_Modelo;
using System.Windows.Forms;

namespace DigiVot_Controlador
{
    class Controlador_Ciudadano
    {
        Vista_Ciudadano vCiudadano;
        public Controlador_Ciudadano(Vista_Ciudadano vCiudadano)
        {
            this.vCiudadano = vCiudadano;
            Eventos_Botones();
        }

        private void Eventos_Botones()
        {

        }
    }
}
