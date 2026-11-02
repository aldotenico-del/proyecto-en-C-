using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Formregitro : Form
    {
        public Formregitro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = TXT_USUARIO2.Text;
            string password = TXT_PAS2.Text;
            string url = "C:\\Users\\user\\OneDrive - Universidad Central del Este\\documentos de la UCE\\MIDEL.COD\\preyectos en C#\\capenta\\" + user + ".txt";
            
            if (File.Exists(url))
            {
                MessageBox.Show("El usuario ya existe. Por favor, elige otro nombre de usuario.");
                TXT_PAS2.Clear();
                TXT_USUARIO2.Clear();
            }
            else
            {
                File.WriteAllText(url, password);
                MessageBox.Show("Usuario registrado exitosamente.");
               
            }
        }
    }
}
