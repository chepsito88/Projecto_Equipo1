using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiVot_Modelo
{
    public class VO_Partidos
    {
        public int id_Partido { get; set; }
        public string  Partido { get; set; }
        public byte[] datos { get; set; }
        public PictureBox picture { get; set; }
    }
}
