﻿using System;
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
    public partial class IntroduccionVerde : Form
    {
        public IntroduccionVerde()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEjercicios_Click(object sender, EventArgs e)
        {
            EjercicioSensopercepcionVerde verde = new EjercicioSensopercepcionVerde();
            verde.ShowDialog();
        }
    }
}
