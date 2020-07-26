using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiVot_Modelo
{
    public class VO_Candidato
    {
        public string Curp { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Partido { get; set; }
        public int IdPartido { get; set; }
        public string Eleccion { get; set; }
        public int IdEleccion { get; set; }
        public byte[] datos { get; set; }
        public PictureBox picture { get; set; }
    }
}
