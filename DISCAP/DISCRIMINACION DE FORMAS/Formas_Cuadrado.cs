using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.DISCRIMINACION_DE_FORMAS
{
    public partial class Formas_Cuadrado : Form
    {
        private int posX;
        private int posY;

        public Formas_Cuadrado()
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
        private void Almohada_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("almohada");
            mi.ShowDialog();
        }
        private void Caja_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("caja");
            mi.ShowDialog();
        }

        private void Pantalla_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("cubo");
            mi.ShowDialog();
        }

        private void Servilleta_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("servilleta");
            mi.ShowDialog();
        }

        private void Ventana_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("ventana");
            mi.ShowDialog();
        }

        private void Cuadro_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("cuadro");
            mi.ShowDialog();
        }

        private void Formas_Cuadrado_Load(object sender, EventArgs e)
        {

        }
    }
}
