namespace WinFormsApp1
{
    partial class REGISTRO_CLIENTE
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
            btn_GURADAR = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label_hora = new Label();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbl_codigo = new Label();
            dataGrid_CLIENTE = new DataGridView();
            TXT_NOMBRE = new TextBox();
            TXT_APELLIDO = new TextBox();
            TXT_DIRECION = new TextBox();
            TXT_CEDULA = new TextBox();
            TXT_CORREO = new TextBox();
            TXT_CODIGO = new TextBox();
            BTN_BACK = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_CLIENTE).BeginInit();
            SuspendLayout();
            // 
            // btn_GURADAR
            // 
            btn_GURADAR.BackColor = Color.FromArgb(0, 0, 64);
            btn_GURADAR.ForeColor = SystemColors.Window;
            btn_GURADAR.Location = new Point(597, 218);
            btn_GURADAR.Name = "btn_GURADAR";
            btn_GURADAR.Size = new Size(272, 62);
            btn_GURADAR.TabIndex = 33;
            btn_GURADAR.Text = "guardar";
            btn_GURADAR.UseVisualStyleBackColor = false;
            btn_GURADAR.Click += btn_GURADAR_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(987, 627);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Window;
            label7.FlatStyle = FlatStyle.Popup;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(613, 36);
            label7.Name = "label7";
            label7.Size = new Size(133, 19);
            label7.TabIndex = 31;
            label7.Text = "HORA DEL SITEMA :";
            // 
            // label_hora
            // 
            label_hora.AutoSize = true;
            label_hora.BackColor = SystemColors.Window;
            label_hora.FlatStyle = FlatStyle.Popup;
            label_hora.ForeColor = Color.Black;
            label_hora.Location = new Point(783, 36);
            label_hora.Name = "label_hora";
            label_hora.Size = new Size(130, 19);
            label_hora.TabIndex = 30;
            label_hora.Text = "HORA DEL SITEMA ";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = SystemColors.Window;
            lbl_Nombre.Location = new Point(62, 154);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(66, 19);
            lbl_Nombre.TabIndex = 29;
            lbl_Nombre.Text = "NOMBRE";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.BackColor = SystemColors.Window;
            lbl_Apellido.Location = new Point(62, 205);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(72, 19);
            lbl_Apellido.TabIndex = 28;
            lbl_Apellido.Text = "APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(69, 258);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 27;
            label4.Text = "DIRECION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Location = new Point(69, 312);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 26;
            label3.Text = "CEDULA ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.FlatStyle = FlatStyle.Popup;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(613, 113);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 25;
            label2.Text = "CORREO";
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.BackColor = SystemColors.Window;
            lbl_codigo.Location = new Point(56, 91);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(64, 19);
            lbl_codigo.TabIndex = 24;
            lbl_codigo.Text = "CODIGO";
            // 
            // dataGrid_CLIENTE
            // 
            dataGrid_CLIENTE.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGrid_CLIENTE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_CLIENTE.Location = new Point(149, 360);
            dataGrid_CLIENTE.Name = "dataGrid_CLIENTE";
            dataGrid_CLIENTE.Size = new Size(720, 247);
            dataGrid_CLIENTE.TabIndex = 23;
            dataGrid_CLIENTE.CellContentClick += dataGrid_ESTUDIANTES_CellContentClick;
            // 
            // TXT_NOMBRE
            // 
            TXT_NOMBRE.BackColor = Color.FromArgb(192, 255, 192);
            TXT_NOMBRE.Location = new Point(134, 151);
            TXT_NOMBRE.Name = "TXT_NOMBRE";
            TXT_NOMBRE.Size = new Size(351, 26);
            TXT_NOMBRE.TabIndex = 22;
            // 
            // TXT_APELLIDO
            // 
            TXT_APELLIDO.BackColor = Color.FromArgb(192, 255, 192);
            TXT_APELLIDO.Location = new Point(140, 202);
            TXT_APELLIDO.Name = "TXT_APELLIDO";
            TXT_APELLIDO.Size = new Size(351, 26);
            TXT_APELLIDO.TabIndex = 21;
            // 
            // TXT_DIRECION
            // 
            TXT_DIRECION.BackColor = Color.FromArgb(192, 255, 192);
            TXT_DIRECION.Location = new Point(140, 251);
            TXT_DIRECION.Name = "TXT_DIRECION";
            TXT_DIRECION.Size = new Size(351, 26);
            TXT_DIRECION.TabIndex = 20;
            // 
            // TXT_CEDULA
            // 
            TXT_CEDULA.BackColor = Color.FromArgb(192, 255, 192);
            TXT_CEDULA.Location = new Point(140, 305);
            TXT_CEDULA.Name = "TXT_CEDULA";
            TXT_CEDULA.Size = new Size(351, 26);
            TXT_CEDULA.TabIndex = 19;
            // 
            // TXT_CORREO
            // 
            TXT_CORREO.BackColor = Color.FromArgb(192, 255, 192);
            TXT_CORREO.Location = new Point(597, 151);
            TXT_CORREO.Name = "TXT_CORREO";
            TXT_CORREO.Size = new Size(264, 26);
            TXT_CORREO.TabIndex = 18;
            // 
            // TXT_CODIGO
            // 
            TXT_CODIGO.BackColor = Color.FromArgb(192, 255, 192);
            TXT_CODIGO.Location = new Point(126, 88);
            TXT_CODIGO.Name = "TXT_CODIGO";
            TXT_CODIGO.Size = new Size(211, 26);
            TXT_CODIGO.TabIndex = 17;
            // 
            // BTN_BACK
            // 
            BTN_BACK.BackColor = Color.FromArgb(0, 0, 64);
            BTN_BACK.ForeColor = SystemColors.Window;
            BTN_BACK.Location = new Point(597, 292);
            BTN_BACK.Name = "BTN_BACK";
            BTN_BACK.Size = new Size(272, 62);
            BTN_BACK.TabIndex = 34;
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
            // REGISTRO_CLIENTE
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 628);
            Controls.Add(BTN_BACK);
            Controls.Add(btn_GURADAR);
            Controls.Add(label7);
            Controls.Add(label_hora);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_Apellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_codigo);
            Controls.Add(dataGrid_CLIENTE);
            Controls.Add(TXT_NOMBRE);
            Controls.Add(TXT_APELLIDO);
            Controls.Add(TXT_DIRECION);
            Controls.Add(TXT_CEDULA);
            Controls.Add(TXT_CORREO);
            Controls.Add(TXT_CODIGO);
            Controls.Add(pictureBox1);
            Name = "REGISTRO_CLIENTE";
            Text = "REGISTRO_CLIENTE";
            Load += REGISTRO_CLIENTE_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_CLIENTE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_GURADAR;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label_hora;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl_codigo;
        private DataGridView dataGrid_CLIENTE;
        private TextBox TXT_NOMBRE;
        private TextBox TXT_APELLIDO;
        private TextBox TXT_DIRECION;
        private TextBox TXT_CEDULA;
        private TextBox TXT_CORREO;
        private TextBox TXT_CODIGO;
        private Button BTN_BACK;
        private System.Windows.Forms.Timer timer1;
    }
}