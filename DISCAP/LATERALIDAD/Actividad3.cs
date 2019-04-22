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

namespace DISCAP.LATERALIDAD
{
    public partial class Actividad3 : Form
    {
        SoundPlayer correcto = new SoundPlayer(Application.StartupPath + @"\sonidos\si.wav");
        SoundPlayer incorrecto = new SoundPlayer(Application.StartupPath + @"\sonidos\no.wav");

        Actividad4 form4 = new Actividad4();
        public Actividad3()
        {
            InitializeComponent();
        }

        private void Actividad3_Load(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {
            label5.Show();
            correcto.Play();

            timer1.Tick += (s, en) =>
            {
                label5.Hide();
                timer1.Stop();
            };
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label6.Show();
            incorrecto.Play();
            timer1.Tick += (s, en) =>
            {
                label6.Hide();
                timer1.Stop();
            };
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
