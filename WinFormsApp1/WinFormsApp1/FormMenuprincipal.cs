using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormMenuprincipal : Form
    {
        public FormMenuprincipal()
        {
            InitializeComponent();


            // LAMBDA DE EXPRESIÓN: botón SALIR del sistema
            BTN_END.Click -= BTN_END_Click;
            BTN_END.Click += (s, ev) => Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void BTN_END_Click(object sender, EventArgs e)
        {
       
        }

        private void rEGITRODECLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRO_CLIENTE resgitr1 = new REGISTRO_CLIENTE();
            this.Hide();
            resgitr1.Show();
        }

        private void rESGITRAREMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRO_EMPLEADO resgitr1 = new REGISTRO_EMPLEADO();
            this.Hide();
            resgitr1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_HORA.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
             FormsProducto forms1 = new FormsProducto();
            this.Hide();
            forms1.Show();
        }
    }
}
