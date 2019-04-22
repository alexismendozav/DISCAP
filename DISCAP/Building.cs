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
    public partial class Building : Form
    {
        public Building()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Building_Load(object sender, EventArgs e)
        {
            Gift.Image = Image.FromFile(Application.StartupPath + @"\Gifs\build.gif");
        }

        private void Gift_Click(object sender, EventArgs e)
        {

        }
    }
}
