namespace WinFormsApp1
{
    partial class REGISTRO_EMPLEADO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_GURADAR_emp = new Button();
            label7 = new Label();
            label_hora_emp = new Label();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbl_codigo = new Label();
            dataGrid_EMPLEADO = new DataGridView();
            TXT_NOMBRE_emp = new TextBox();
            TXT_APELLIDO_emp = new TextBox();
            TXT_CARGO_emp = new TextBox();
            TXT_AREA_emp = new TextBox();
            TXT_CORREO_emp = new TextBox();
            TXT_CODIGO_emp = new TextBox();
            pictureBox1 = new PictureBox();
            BTN_BACK = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGrid_EMPLEADO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_GURADAR_emp
            // 
            btn_GURADAR_emp.BackColor = Color.FromArgb(0, 0, 64);
            btn_GURADAR_emp.ForeColor = SystemColors.Window;
            btn_GURADAR_emp.Location = new Point(497, 178);
            btn_GURADAR_emp.Margin = new Padding(3, 2, 3, 2);
            btn_GURADAR_emp.Name = "btn_GURADAR_emp";
            btn_GURADAR_emp.Size = new Size(238, 49);
            btn_GURADAR_emp.TabIndex = 50;
            btn_GURADAR_emp.Text = "guardar";
            btn_GURADAR_emp.UseVisualStyleBackColor = false;
            btn_GURADAR_emp.Click += btn_GURADAR_emp_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Window;
            label7.FlatStyle = FlatStyle.Popup;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(549, 34);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 48;
            label7.Text = "HORA DEL SITEMA :";
            // 
            // label_hora_emp
            // 
            label_hora_emp.AutoSize = true;
            label_hora_emp.BackColor = SystemColors.Window;
            label_hora_emp.FlatStyle = FlatStyle.Popup;
            label_hora_emp.ForeColor = SystemColors.ActiveCaptionText;
            label_hora_emp.Location = new Point(697, 34);
            label_hora_emp.Name = "label_hora_emp";
            label_hora_emp.Size = new Size(110, 15);
            label_hora_emp.TabIndex = 47;
            label_hora_emp.Text = "HORA DEL SITEMA ";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = SystemColors.Window;
            lbl_Nombre.Location = new Point(34, 134);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(56, 15);
            lbl_Nombre.TabIndex = 46;
            lbl_Nombre.Text = "NOMBRE";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.BackColor = SystemColors.Window;
            lbl_Apellido.Location = new Point(34, 178);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(60, 15);
            lbl_Apellido.TabIndex = 45;
            lbl_Apellido.Text = "APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(34, 216);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 44;
            label4.Text = "CARGO";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Location = new Point(34, 259);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 43;
            label3.Text = "AREA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.FlatStyle = FlatStyle.Popup;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(523, 111);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 42;
            label2.Text = "CORREO";
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.BackColor = SystemColors.Window;
            lbl_codigo.Location = new Point(34, 84);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(52, 15);
            lbl_codigo.TabIndex = 41;
            lbl_codigo.Text = "CODIGO";
            // 
            // dataGrid_EMPLEADO
            // 
            dataGrid_EMPLEADO.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGrid_EMPLEADO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_EMPLEADO.Location = new Point(73, 294);
            dataGrid_EMPLEADO.Margin = new Padding(3, 2, 3, 2);
            dataGrid_EMPLEADO.Name = "dataGrid_EMPLEADO";
            dataGrid_EMPLEADO.Size = new Size(732, 195);
            dataGrid_EMPLEADO.TabIndex = 40;
            dataGrid_EMPLEADO.CellContentClick += dataGrid_Empledado_CellContentClick;
            // 
            // TXT_NOMBRE_emp
            // 
            TXT_NOMBRE_emp.BackColor = Color.FromArgb(64, 64, 0);
            TXT_NOMBRE_emp.ForeColor = SystemColors.Window;
            TXT_NOMBRE_emp.Location = new Point(102, 132);
            TXT_NOMBRE_emp.Margin = new Padding(3, 2, 3, 2);
            TXT_NOMBRE_emp.Name = "TXT_NOMBRE_emp";
            TXT_NOMBRE_emp.Size = new Size(308, 23);
            TXT_NOMBRE_emp.TabIndex = 39;
            // 
            // TXT_APELLIDO_emp
            // 
            TXT_APELLIDO_emp.BackColor = Color.FromArgb(64, 64, 0);
            TXT_APELLIDO_emp.ForeColor = SystemColors.Window;
            TXT_APELLIDO_emp.Location = new Point(102, 172);
            TXT_APELLIDO_emp.Margin = new Padding(3, 2, 3, 2);
            TXT_APELLIDO_emp.Name = "TXT_APELLIDO_emp";
            TXT_APELLIDO_emp.Size = new Size(308, 23);
            TXT_APELLIDO_emp.TabIndex = 38;
            // 
            // TXT_CARGO_emp
            // 
            TXT_CARGO_emp.BackColor = Color.FromArgb(64, 64, 0);
            TXT_CARGO_emp.ForeColor = SystemColors.Window;
            TXT_CARGO_emp.Location = new Point(102, 214);
            TXT_CARGO_emp.Margin = new Padding(3, 2, 3, 2);
            TXT_CARGO_emp.Name = "TXT_CARGO_emp";
            TXT_CARGO_emp.Size = new Size(308, 23);
            TXT_CARGO_emp.TabIndex = 37;
            // 
            // TXT_AREA_emp
            // 
            TXT_AREA_emp.BackColor = Color.FromArgb(64, 64, 0);
            TXT_AREA_emp.ForeColor = SystemColors.Window;
            TXT_AREA_emp.Location = new Point(102, 257);
            TXT_AREA_emp.Margin = new Padding(3, 2, 3, 2);
            TXT_AREA_emp.Name = "TXT_AREA_emp";
            TXT_AREA_emp.Size = new Size(308, 23);
            TXT_AREA_emp.TabIndex = 36;
            // 
            // TXT_CORREO_emp
            // 
            TXT_CORREO_emp.BackColor = Color.FromArgb(64, 64, 0);
            TXT_CORREO_emp.ForeColor = SystemColors.Window;
            TXT_CORREO_emp.Location = new Point(497, 141);
            TXT_CORREO_emp.Margin = new Padding(3, 2, 3, 2);
            TXT_CORREO_emp.Name = "TXT_CORREO_emp";
            TXT_CORREO_emp.Size = new Size(232, 23);
            TXT_CORREO_emp.TabIndex = 35;
            // 
            // TXT_CODIGO_emp
            // 
            TXT_CODIGO_emp.BackColor = Color.FromArgb(64, 64, 0);
            TXT_CODIGO_emp.ForeColor = SystemColors.Window;
            TXT_CODIGO_emp.Location = new Point(94, 82);
            TXT_CODIGO_emp.Margin = new Padding(3, 2, 3, 2);
            TXT_CODIGO_emp.Name = "TXT_CODIGO_emp";
            TXT_CODIGO_emp.Size = new Size(185, 23);
            TXT_CODIGO_emp.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(1, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(875, 497);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // BTN_BACK
            // 
            BTN_BACK.BackColor = Color.FromArgb(0, 0, 64);
            BTN_BACK.ForeColor = SystemColors.Window;
            BTN_BACK.Location = new Point(497, 240);
            BTN_BACK.Margin = new Padding(3, 2, 3, 2);
            BTN_BACK.Name = "BTN_BACK";
            BTN_BACK.Size = new Size(238, 49);
            BTN_BACK.TabIndex = 51;
            BTN_BACK.Text = "ATRAS";
            BTN_BACK.UseVisualStyleBackColor = false;
            BTN_BACK.Click += BTN_BACK_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // REGISTRO_EMPLEADO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 499);
            Controls.Add(BTN_BACK);
            Controls.Add(btn_GURADAR_emp);
            Controls.Add(label7);
            Controls.Add(label_hora_emp);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_Apellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_codigo);
            Controls.Add(dataGrid_EMPLEADO);
            Controls.Add(TXT_NOMBRE_emp);
            Controls.Add(TXT_APELLIDO_emp);
            Controls.Add(TXT_CARGO_emp);
            Controls.Add(TXT_AREA_emp);
            Controls.Add(TXT_CORREO_emp);
            Controls.Add(TXT_CODIGO_emp);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "REGISTRO_EMPLEADO";
            Text = "REGISTRO_EMPLEADO";
            ((System.ComponentModel.ISupportInitialize)dataGrid_EMPLEADO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_GURADAR_emp;
        private Label label7;
        private Label label_hora_emp;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl_codigo;
        private DataGridView dataGrid_EMPLEADO;
        private TextBox TXT_NOMBRE_emp;
        private TextBox TXT_APELLIDO_emp;
        private TextBox TXT_CARGO_emp;
        private TextBox TXT_AREA_emp;
        private TextBox TXT_CORREO_emp;
        private TextBox TXT_CODIGO_emp;
        private PictureBox pictureBox1;
        private Button BTN_BACK;
        private System.Windows.Forms.Timer timer1;
    }
}