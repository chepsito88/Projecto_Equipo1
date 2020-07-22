using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    public class VO_Ciudadano
    {
        public string Curp { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Vigencia { get; set; }
        public int Direccion { get; set; }
    }
}
