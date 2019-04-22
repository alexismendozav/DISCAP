using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.MEMORIA_AUDITIVA
{
    public partial class Sonidos : Form
    {
       
        public Sonidos()
        {
            InitializeComponent();
        }

        private void Catedral_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes mostrar_Imagenes = new DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes("Iglesia",1);
            mostrar_Imagenes.ShowDialog();
            //sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\iglesia.wav");
            //sonido.Play();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Patrulla_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes mostrar_Imagenes = new DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes("patrulla",1);
            mostrar_Imagenes.ShowDialog();
        }

        private void Perro_Click(object sender, EventArgs e)
        {
            //sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\perro.wav");
            //sonido.Play();
            DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes mostrar_Imagenes = new DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes("perro",1);
            mostrar_Imagenes.ShowDialog();
        }
      

        private void Peatonal_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes mostrar_Imagenes = new DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes("Peatonal");
            mostrar_Imagenes.ShowDialog();
        }

        private void Licuadora_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes mostrar_Imagenes = new DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes("Licuadora");
            mostrar_Imagenes.ShowDialog();
        }

        private void Urban_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes mostrar_Imagenes = new DISCRIMINACION_DE_FORMAS.Mostrar_Imagenes("Urban");
            mostrar_Imagenes.ShowDialog();
        }

        private void Sonidos_Load(object sender, EventArgs e)
        {

        }
    }
}
