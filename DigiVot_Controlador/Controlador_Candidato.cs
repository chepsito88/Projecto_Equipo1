using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiVot_Vista;
using DigiVot_Modelo;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace DigiVot_Controlador
{
    class Controlador_Candidato
    {
        Vista_Candidato vCandidato;
        public Controlador_Candidato(Vista_Candidato vCandidato)
        {
            this.vCandidato = vCandidato;
            Eventos_Botones();
        }

        private void Eventos_Botones()
        {
            vCandidato.btnAgregarImagen.Click += Click_AgregarImagen;
        }

        private void Click_AgregarImagen(object sender, EventArgs e)
        {
            string URLImagen;
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Selecione el achivo adecuado";
            abrir.Filter = "Archivos (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                URLImagen = abrir.SafeFileName;
                //lblImagen.Text = abrir.SafeFileName;
                vCandidato.ptbImagenCandidato.Image = Image.FromFile(abrir.FileName);
            }
            else
            {
                abrir.Dispose();
                MessageBox.Show("No selecionó ningun archivo");
            }
        }
    }
}
