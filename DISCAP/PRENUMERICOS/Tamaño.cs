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

namespace DISCAP.PRENUMERICOS
{
    public partial class Tamaño : Form
    {
        SoundPlayer correcto = new SoundPlayer(Application.StartupPath + @"\sonidos\si.wav");
        SoundPlayer incorrecto = new SoundPlayer(Application.StartupPath + @"\sonidos\no.wav");
        public Tamaño()
        {
            InitializeComponent();
            correcto.Load();
            incorrecto.Load();
        }

        private void Tamaño_Load(object sender, EventArgs e)
        {

        }

        private void btnImagen1_Click(object sender, EventArgs e)
        {
            lblIncorrecto1.Show();
            incorrecto.Play();
            timer1.Start();

            timer1.Tick += (s, en) =>
            {
                lblIncorrecto1.Hide();
                timer1.Stop();
            };
        }

        private void btnImagen2_Click(object sender, EventArgs e)
        {
            lblCorrecto1.Show();
            correcto.Play();
            timer1.Start();

            timer1.Tick += (s, en) =>
            {
                lblCorrecto1.Hide();
                timer1.Stop();
            };
        }

        private void btnImagen3_Click(object sender, EventArgs e)
        {
            lblCorrecto2.Show();
            correcto.Play();
            timer1.Start();

            timer1.Tick += (s, en) =>
            {
                lblCorrecto2.Hide();
                timer1.Stop();
            };
        }

        private void btnImagen4_Click(object sender, EventArgs e)
        {
            lblIncorrecto2.Show();
            incorrecto.Play();
            timer1.Start();

            timer1.Tick += (s, en) =>
            {
                lblIncorrecto2.Hide();
                timer1.Stop();
            };
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
