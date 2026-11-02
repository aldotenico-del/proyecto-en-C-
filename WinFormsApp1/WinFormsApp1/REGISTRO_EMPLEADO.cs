using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class REGISTRO_EMPLEADO : Form
    {
        public REGISTRO_EMPLEADO()
        {
            InitializeComponent();
            dataGrid_EMPLEADO.ColumnCount = 6;
            dataGrid_EMPLEADO.Columns[0].Name = "codigo ";
            dataGrid_EMPLEADO.Columns[1].Name = "Nombre";
            dataGrid_EMPLEADO.Columns[2].Name = "Apellido";
            dataGrid_EMPLEADO.Columns[3].Name = "CARGO";
            dataGrid_EMPLEADO.Columns[4].Name = "AREA";
            dataGrid_EMPLEADO.Columns[5].Name = "correo"; 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGrid_Empledado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitializeComponent();
            dataGrid_EMPLEADO.ColumnCount = 6;
            dataGrid_EMPLEADO.Columns[0].Name = "codigo ";
            dataGrid_EMPLEADO.Columns[1].Name = "Nombre";
            dataGrid_EMPLEADO.Columns[2].Name = "Apellido";
            dataGrid_EMPLEADO.Columns[3].Name = "CARGO";
            dataGrid_EMPLEADO.Columns[4].Name = "AREA";
            dataGrid_EMPLEADO.Columns[5].Name = "correo";
        }

        private void btn_GURADAR_emp_Click(object sender, EventArgs e)
        {
            string nombre = TXT_NOMBRE_emp.Text;
            string apellido = TXT_APELLIDO_emp.Text;
            string AREA = TXT_AREA_emp.Text;
            string CARGO = TXT_CARGO_emp.Text;
            string codigo = TXT_CODIGO_emp.Text;
            string correo = TXT_CORREO_emp.Text;

            dataGrid_EMPLEADO.Rows.Add(codigo, nombre, apellido, CARGO, AREA, correo);
            TXT_CODIGO_emp.Clear();
            TXT_NOMBRE_emp.Clear();
            TXT_APELLIDO_emp.Clear();
            TXT_AREA_emp.Clear();
            TXT_CARGO_emp.Clear();
            TXT_CORREO_emp.Clear();
        }

        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            FormMenuprincipal FormMenu = new FormMenuprincipal();
            this.Hide();
            FormMenu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_hora_emp.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
