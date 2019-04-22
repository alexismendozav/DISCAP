using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP
{
    public partial class Discriminacion_de_formas : Form
    {
        private int posX;
        private int posY;
        Categorias formCategorias;

        public Discriminacion_de_formas()
        {
            InitializeComponent();
        }

        //CIERRA LA APLICACION
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //EVENTO QUE MUEVE EL FORM DE POSISCION 
        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
        //MAXIMIZAR FORM
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
                //btnSensopercepcion.Font = new Font(new FontFamily("Montserrat"), 20);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        //OBTIENE EL FORM PRINCIPAL ->
        public void setForm(Categorias formCategorias)
        {
            this.formCategorias = formCategorias;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            formCategorias.Visible = true;
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "circulo.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
            lblFiguras.Text = "CÍRCULO";
        }

        private void BtnCuadrado_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "cuadrado.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
            lblFiguras.Text = "CUADRADO";
        }

        private void BtnTriangulo_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "triangulo.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
            lblFiguras.Text = "TRIANGULO";
        }

        private void BtnRectangulo_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "rectangulo.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
            lblFiguras.Text = "RECTANGULO";
        }

        private void Discriminacion_de_formas_Load(object sender, EventArgs e)
        {

        }

        private void BtnInfo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
