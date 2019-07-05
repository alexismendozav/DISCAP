using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.ESQUEMA_CORPORAL
{
    public partial class EsquemaCorporal : Form
    {
        public EsquemaCorporal()
        {
            InitializeComponent();
      
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
