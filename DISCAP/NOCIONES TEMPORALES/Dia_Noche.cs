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
    public partial class Dia_Noche : Form
    {
        SoundPlayer sonido;
        public Dia_Noche()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\Gifs\tenor.gif");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\Gifs\noche.gif");
        }

        private void Dia_Noche_Load(object sender, EventArgs e)
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\dia_noche.wav");
            sonido.Play();
        }
      


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\aplausos.wav");
                sonido.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }



        private void mouse_gallo(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\aplausos.wav");
            sonido.Play();

        }

        private void sonido_dia()
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\gallo.wav");
            sonido.Play();
        }

        private void sonido_noche(object sender, MouseEventArgs e)
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\noche.wav");
            sonido.Play();
        }

        private void sonido_grillo()
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\grillo.wav");
            sonido.Play();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            sonido.Stop();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            sonido_dia();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sonido_grillo();
        }
    }
}

