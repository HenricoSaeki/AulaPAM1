﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HenricoeJoaoP
{
    public partial class frmprograma : Form
    {
        public frmprograma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geradorDeNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgerador  gerador = new frmgerador();
            this.Hide();
            gerador.Show();
        }
    }
}
