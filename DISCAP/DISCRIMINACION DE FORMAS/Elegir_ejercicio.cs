using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP
{
    public partial class Elegir_ejercicio : Form
    {
        private int posX;
        private int posY;

        public Elegir_ejercicio()
        {
            InitializeComponent();
        }

        private void BtnFormas_Click(object sender, EventArgs e)
        {
            Discriminacion_de_formas ddf = new Discriminacion_de_formas();
            ddf.WindowState = FormWindowState.Maximized;
            ddf.ShowDialog();
        }

        private void Elegir_ejercicio_Load(object sender, EventArgs e)
        {

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

        private void Button1_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Formas_Circulo circulos = new DISCRIMINACION_DE_FORMAS.Formas_Circulo();
            circulos.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Formas_Cuadrado cuadrado = new DISCRIMINACION_DE_FORMAS.Formas_Cuadrado();
            cuadrado.ShowDialog();
        }

        private void Rectangulos_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Formas_Rectangulo cuadrado = new DISCRIMINACION_DE_FORMAS.Formas_Rectangulo();
            cuadrado.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Formas_Triangulo cuadrado = new DISCRIMINACION_DE_FORMAS.Formas_Triangulo();
            cuadrado.ShowDialog();
        }

        private void Where_Cube_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Adivina_El_Cuadrado form = new DISCRIMINACION_DE_FORMAS.Adivina_El_Cuadrado();
            form.ShowDialog();
        }

        private void Where_C_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Adivina_El_Circulo form = new DISCRIMINACION_DE_FORMAS.Adivina_El_Circulo();
            form.ShowDialog();
        }

        private void Where_Rectangle_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Adivina_El_Rectangulo form = new DISCRIMINACION_DE_FORMAS.Adivina_El_Rectangulo();
            form.ShowDialog();
        }

        private void Where_T_Click(object sender, EventArgs e)
        {
            DISCRIMINACION_DE_FORMAS.Adivina_El_Triangulo form = new DISCRIMINACION_DE_FORMAS.Adivina_El_Triangulo();
            form.ShowDialog();
        }
    }
}
