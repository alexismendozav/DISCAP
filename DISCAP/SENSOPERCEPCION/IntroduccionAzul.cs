using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.SENSOPERCEPCION
{
    public partial class IntroduccionAzul : Form
    {
        public IntroduccionAzul()
        {
            InitializeComponent();
        }

        private void buttonEjercicios_Click(object sender, EventArgs e)
        {
            EjercicioSensopercepcionAzul azul = new EjercicioSensopercepcionAzul();
            azul.Show();
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
