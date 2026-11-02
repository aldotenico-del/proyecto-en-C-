using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class REGISTRO_CLIENTE : Form
    {
        public REGISTRO_CLIENTE()
        {
            InitializeComponent();
            dataGrid_CLIENTE.ColumnCount = 6;
            dataGrid_CLIENTE.Columns[0].Name = "codigo ";
            dataGrid_CLIENTE.Columns[1].Name = "Nombre";
            dataGrid_CLIENTE.Columns[2].Name = "Apellido";
            dataGrid_CLIENTE.Columns[3].Name = "Direccion";
            dataGrid_CLIENTE.Columns[4].Name = "cedula";
            dataGrid_CLIENTE.Columns[5].Name = "correo";
        }

        private void REGISTRO_CLIENTE_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid_ESTUDIANTES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid_CLIENTE.ColumnCount = 6;
            dataGrid_CLIENTE.Columns[0].Name = "codigo ";
            dataGrid_CLIENTE.Columns[1].Name = "Nombre";
            dataGrid_CLIENTE.Columns[2].Name = "Apellido";
            dataGrid_CLIENTE.Columns[3].Name = "Direccion";
            dataGrid_CLIENTE.Columns[4].Name = "cedula";
            dataGrid_CLIENTE.Columns[5].Name = "correo";
        }

        private void btn_GURADAR_Click(object sender, EventArgs e)
        {
            string nombre = TXT_NOMBRE.Text;
            string apellido = TXT_APELLIDO.Text;
            string direccion = TXT_DIRECION.Text;
            string cedula = TXT_CEDULA.Text;
            string codigo = TXT_CODIGO.Text;
            string correo = TXT_CORREO.Text;

            dataGrid_CLIENTE.Rows.Add(codigo, nombre, apellido, direccion, cedula, correo);
            TXT_CODIGO.Clear();
            TXT_NOMBRE.Clear();
            TXT_APELLIDO.Clear();
            TXT_DIRECION.Clear();
            TXT_CEDULA.Clear();
            TXT_CORREO.Clear();
        }

        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            FormMenuprincipal FormMenu = new FormMenuprincipal();
            this.Hide();
            FormMenu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
