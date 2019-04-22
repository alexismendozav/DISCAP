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
    public partial class Inicio : Form
    {
        private int posX;
        private int posY;

        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }
        //CIERRA LA APLICACION
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //EVENTO QUE MUEVE EL FORM DE POSISCION 
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
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
        //    if (WindowState.ToString() == "Normal")
        //    {
        //        this.WindowState = FormWindowState.Maximized;

        //    }
        //    else
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //    }
        }

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            Categorias ejercicios = new Categorias();
            this.Hide();
            ejercicios.WindowState = FormWindowState.Maximized;
            ejercicios.Show();
            ejercicios.setForm(this);
            
        }

        private void lblEjercicios_Click(object sender, EventArgs e)
        {
            ////Categorias ejercicios = new Categorias();
            ////this.Hide();
            ////ejercicios.Show();
            ////ejercicios.setForm(this);
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Building building = new Building();
            building.ShowDialog();
        }
    }
}
