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

namespace Calculo
{
    public partial class Posterior1 : Form
    {
        private int posX;
        private int posY;
        SoundPlayer play = new SoundPlayer();//OBJETO DE TIPO SOUNDPLAYER PARA REPRODUCIR AUDIOS
        SoundPlayer correcta = new SoundPlayer("C:/Users/rauloscar/Desktop/Calculo/Audios/Correcto.wav");//OBJETO DE TIPO SOUNDPLAYER PARA REPRODUCIR AUDIOS
        SoundPlayer incorrecta = new SoundPlayer("C:/Users/rauloscar/Desktop/Calculo/Audios/Incorrecto.wav");//OBJETO DE TIPO SOUNDPLAYER PARA REPRODUCIR AUDIOS

        public Posterior1()
        {
            InitializeComponent();
        }

        //BOTÓN MAXIMIZAR. MAXIMIZA O MINIMIZA LA VENTANA EN EJECUCIÓN
        private void maximizar_Click(object sender, EventArgs e)
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

        //BOTÓN CERRAR
        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODO PARA HACER RESPONSIVO EL PANEL
        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
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

        private void retroceder_Click(object sender, EventArgs e)
        {
          
        }

        //BOTÓN PARA VISUALIZAR LA SIGUIENTE VENTANA
        private void sigVentana_Click(object sender, EventArgs e)
        {
            Posterior2 ventana = new Posterior2();
            ventana.Show();
            this.Visible = false;//OCULTA VENTANA ACTUAL
        }

        //BOTÓN OPCIÓN 1
        private void opcion1_Click(object sender, EventArgs e)
        {
            incorrecta.Play();
            incorrecto1.Show();

            timer1.Tick += (s, en) =>
            {
                incorrecto1.Hide();
                timer1.Stop();
            };
            timer1.Start();
        }

        //BOTÓN OPCIÓN 2
        private void opcion2_Click(object sender, EventArgs e)
        {
            correcta.Play();
            correcto.Show();

            timer1.Tick += (s, en) =>
            {
                correcto.Hide();
                timer1.Stop();
            };
            timer1.Start();
        }

        //BOTÓN OPCIÓN 3
        private void opcion3_Click(object sender, EventArgs e)
        {
            incorrecta.Play();
            incorrecto2.Show();

            timer1.Tick += (s, en) =>
            {
                incorrecto2.Hide();
                timer1.Stop();
            };
            timer1.Start();
        }
    }
}
