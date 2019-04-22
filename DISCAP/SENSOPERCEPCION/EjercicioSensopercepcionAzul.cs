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
    public partial class EjercicioSensopercepcionAzul : Form
    {
        public EjercicioSensopercepcionAzul()
        {
            InitializeComponent();
            EjercicioAleatorios();
        }

        private void EjercicioSensopercepcionAzul_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void EjercicioAleatorios()
        {
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(1, 5);
            switch (numeroAleatorio)
            {
                case 1:
                    buttonImagen1.Image = Image.FromFile("suderaAzul.jpg");
                    buttonImagen2.Image = Image.FromFile("perroCafe.jpg");
                    buttonImagen3.Image = Image.FromFile("libretaAzul.jpg");
                    break;
                case 2:
                    buttonImagen1.Image = Image.FromFile("libretaAzul.jpg");
                    buttonImagen2.Image = Image.FromFile("pantalonAzull.jpg");
                    buttonImagen3.Image = Image.FromFile("zapatosNegros.jpg");
                    break;
                case 3:
                    buttonImagen1.Image = Image.FromFile("pantalonAzull.jpg");
                    buttonImagen2.Image = Image.FromFile("suderaAzul.jpg");
                    buttonImagen3.Image = Image.FromFile("fresaRoja2.jpg");
                    break;
                case 4:
                    buttonImagen1.Image = Image.FromFile("moñoMorado.jpg");
                    buttonImagen2.Image = Image.FromFile("libretaAzul.jpg");
                    buttonImagen3.Image = Image.FromFile("pantalonAzull.jpg");
                    break;
                case 5:
                    buttonImagen1.Image = Image.FromFile("maletaAzul.jpg");
                    buttonImagen2.Image = Image.FromFile("gorraRoja.jpg");
                    buttonImagen3.Image = Image.FromFile("suderaAzul.jpg");
                    break;
            }
        }
    }
}
