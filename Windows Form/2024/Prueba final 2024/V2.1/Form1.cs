using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes repo = new Reportes();
            repo.Show();
            repo.BringToFront();
        }

        private void proovedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            admin.Show();
            admin.BringToFront();


        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos prod = new productos();
            prod.Show();
            prod.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
