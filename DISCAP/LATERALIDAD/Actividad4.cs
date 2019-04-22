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
    public partial class Actividad4 : Form
    {
        SoundPlayer correcto = new SoundPlayer(Application.StartupPath + @"\sonidos\si.wav");
        SoundPlayer incorrecto = new SoundPlayer(Application.StartupPath + @"\sonidos\no.wav");
        Actividad5 form5 = new Actividad5();
        public Actividad4()
        {
            InitializeComponent();
            correcto.Load();
            incorrecto.Load();
        }

        private void Actividad4_Load(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }
    }
}
