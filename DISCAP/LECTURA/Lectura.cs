﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.LECTURA
{
    public partial class Lectura : Form
    {
        public Lectura()
        {
            InitializeComponent();
        }

        private void Lectura_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RepasoLetras repasoLetras = new RepasoLetras();
            repasoLetras.ShowDialog();
        }
    }
}