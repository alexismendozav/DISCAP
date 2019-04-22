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

namespace DISCAP.NOCIONES_TEMPORALES
{
    public partial class Dias_de_la_semana : Form
    {
        SoundPlayer sonido;
        private int posX;
        private int posY;
        public Dias_de_la_semana()
        {
            InitializeComponent();
        }

        private void Dias_de_la_semana_Load(object sender, EventArgs e)
        {

        }
        private void LUNES_MouseHover(object sender, EventArgs e)
        {
            dias.Text = "Lunes";
            dias.Font = new Font(Font.FontFamily.Name, 50);

            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\lunes.wav");
            sonido.Play();
        }

        private void MARTES_MouseHover(object sender, EventArgs e)
        {
            dias.Text = "Martes";
            dias.Font = new Font(Font.FontFamily.Name, 50);

            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\martes.wav");
            sonido.Play();
        }

        private void MIERCOLES_MouseHover(object sender, EventArgs e)
        {
           dias.Text = "Miercoles";
            dias.Font = new Font(Font.FontFamily.Name, 45);

            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\miercoles.wav");
            sonido.Play();
        }

        private void JUEVES_MouseHover(object sender, EventArgs e)
        {
            dias.Text = "Jueves";
            dias.Font = new Font(Font.FontFamily.Name, 50);

            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\jueves.wav");
            sonido.Play();
        }

        private void VIERNES_MouseHover(object sender, EventArgs e)
        {
            dias.Text = "Viernes";
            dias.Font = new Font(Font.FontFamily.Name, 50);

            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\viernes.wav");
            sonido.Play();
        }

        private void SABADO_MouseHover(object sender, EventArgs e)
        {
            dias.Text = "Sábado";
            dias.Font = new Font(Font.FontFamily.Name, 50);

            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\sabado.wav");
            sonido.Play();
        }

        private void DOMINGO_MouseHover(object sender, EventArgs e)
        {
            dias.Text = "Domingo";
           
            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\domingo.wav");
            sonido.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\introduccion.wav");
            sonido.Play();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dias_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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


    }
}
