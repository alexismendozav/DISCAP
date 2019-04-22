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

namespace DISCAP.DISCRIMINACION_DE_FORMAS
{

    public partial class Formas_Circulo : Form
    {
        SoundPlayer sonido;
        private int posX;
        private int posY;

        public Formas_Circulo()
        {
            InitializeComponent();
        }

        private void Discriminacion_de_formas_2_Load(object sender, EventArgs e)
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

        //OBTIENE EL FORM PRINCIPAL ->
        public void setForm(Inicio formPrincipal)
        {
           // this.formPrincipal = formPrincipal;
        }

        private void Reloj_Click(object sender, EventArgs e)
        {              
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Reloj2");
            mi.ShowDialog();
        }

        private void Luna_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("luna");
            mi.ShowDialog();
        }

        private void Pizza_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("pizza");
            mi.ShowDialog();
        }

        private void Llanta_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("llanta");
            mi.ShowDialog();
        }

        private void Moneda_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("moneda");
            mi.ShowDialog();
        }

        private void Reproducir(string name)
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\DDF\"+name+".wav");
            sonido.Play();
        }

        private void Pizza_MouseHover(object sender, EventArgs e)
        {
            //reproducir("pizza");
        }

        private void Llanta_MouseHover(object sender, EventArgs e)
        {
            //reproducir("llanta");
        }

        private void Luna_MouseHover(object sender, EventArgs e)
        {
            //reproducir("grillo");
        }

        private void Reloj_MouseHover(object sender, EventArgs e)
        {
            //reproducir("reloj");
        }

        private void Cd_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("cd");
            mi.ShowDialog();
        }
    }
}
