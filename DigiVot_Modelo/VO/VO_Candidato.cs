using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    public class VO_Candidato
    {
        public string Curp { get; set; }
        public string Nombre { get; set; }
        public string Partido { get; set; }
        public int IdPartido { get; set; }
        public string Eleccion { get; set; }
        public int IdEleccion { get; set; }
        public string Foto { get; set; }
    }
}
