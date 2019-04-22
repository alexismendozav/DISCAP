using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.SENSOPERCEPCION
{
    public partial class EjercicioSensopercepcionRosa : Form
    {
        public EjercicioSensopercepcionRosa()
        {
            InitializeComponent();
            EjercicioAleatorios();
        }

        private void EjercicioSensopercepcionRosa_Load(object sender, EventArgs e)
        {

        }
        public void EjercicioAleatorios()
        {
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(1, 5);
            switch (numeroAleatorio)
            {
                case 1:
                    buttonImagen1.Image = Image.FromFile("gorraRosa.jpg");
                    buttonImagen2.Image = Image.FromFile("mochilaRosa.jpg");
                    buttonImagen3.Image = Image.FromFile("libretaAzul.jpg");
                    break;
                case 2:
                    buttonImagen1.Image = Image.FromFile("limones.jpg");
                    buttonImagen2.Image = Image.FromFile("SudaderaRosa.jpg");
                    buttonImagen3.Image = Image.FromFile("mochilaRosa.jpg");
                    break;
                case 3:
                    buttonImagen1.Image = Image.FromFile("blusaRosa.jpg");
                    buttonImagen2.Image = Image.FromFile("ranaVerde.jpg");
                    buttonImagen3.Image = Image.FromFile("gorraRosa.jpg");
                    break;
                case 4:
                    buttonImagen1.Image = Image.FromFile("SudaderaRosa.jpg");
                    buttonImagen2.Image = Image.FromFile("blusaRosa.jpg");
                    buttonImagen3.Image = Image.FromFile("ranaVerde.jpg");
                    break;
                case 5:
                    buttonImagen1.Image = Image.FromFile("sombrillaVerde.jpg");
                    buttonImagen2.Image = Image.FromFile("gorraRosa.jpg");
                    buttonImagen3.Image = Image.FromFile("blusaRosa.jpg");
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
