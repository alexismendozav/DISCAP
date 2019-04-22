using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.NOCIONES_TEMPORALES
{
    public partial class Ejercicios_Neuroespaciales : Form
    {
        private int posX;
        private int posY;

        public Ejercicios_Neuroespaciales()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Dias_de_la_semana dias = new Dias_de_la_semana();
            dias.ShowDialog();
        }
        //CIERRA LA APLICACION
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //EVENTO QUE MUEVE EL FORM DE POSISCION 
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
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
        private void btnMaximize_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dia_Noche dn = new Dia_Noche();
            dn.ShowDialog();
        }
    }
}
