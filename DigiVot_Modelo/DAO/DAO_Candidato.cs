using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiVot_Modelo
{
    class DAO_Candidato
    {
        string destino = @"C:\Projecto\Imagenes\";
        public void GuardarImagen(PictureBox picture,string foto) {
            picture.Image.Save(destino + foto, ImageFormat.Jpeg);
        }

        public void actualizaImagen(PictureBox picture, string foto, string reemplazo) {
            String pathTmp = destino+reemplazo;
            if (File.Exists(pathTmp))
            {
                File.Delete(pathTmp);
            }

            picture.Image.Save(destino + foto, ImageFormat.Jpeg);
        }

        public void eliminaImagen(string foto) {
            File.Delete(destino+foto);
        }
      
    }
}
