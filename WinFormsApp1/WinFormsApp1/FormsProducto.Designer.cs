namespace WinFormsApp1
{
    partial class FormsProducto
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
            BTN_BACK_product = new Button();
            btn_GURADAR_produc = new Button();
            label7 = new Label();
            label_hora_emp = new Label();
            lbl_Nombre = new Label();
            lbl_PRECIO = new Label();
            label4 = new Label();
            label3 = new Label();
            lbl_codigo = new Label();
            dataGrid_PRODUCTO = new DataGridView();
            TXT_NOMBRE_product = new TextBox();
            TXT_PRECIO = new TextBox();
            TXT_CANTIDAD = new TextBox();
            TXT_DESCRIPCION = new TextBox();
            TXT_CODIGO_produc = new TextBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            TXT_FILTRO_PRECIO = new TextBox();
            btn_FILTRAR_product = new Button();
            btn_MOSTRAR_TODO_product = new Button();
            btn_ELIMINAR_product = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_PRODUCTO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTN_BACK_product
            // 
            BTN_BACK_product.BackColor = Color.FromArgb(0, 0, 64);
            BTN_BACK_product.FlatStyle = FlatStyle.Popup;
            BTN_BACK_product.ForeColor = SystemColors.Window;
            BTN_BACK_product.Location = new Point(717, 235);
            BTN_BACK_product.Margin = new Padding(3, 2, 3, 2);
            BTN_BACK_product.Name = "BTN_BACK_product";
            BTN_BACK_product.Size = new Size(108, 49);
            BTN_BACK_product.TabIndex = 69;
            BTN_BACK_product.Text = "ATRAS";
            BTN_BACK_product.UseVisualStyleBackColor = false;
            BTN_BACK_product.Click += BTN_BACK_product_Click;
            // 
            // btn_GURADAR_produc
            // 
            btn_GURADAR_produc.BackColor = Color.FromArgb(0, 0, 64);
            btn_GURADAR_produc.FlatStyle = FlatStyle.Popup;
            btn_GURADAR_produc.ForeColor = SystemColors.Window;
            btn_GURADAR_produc.Location = new Point(717, 172);
            btn_GURADAR_produc.Margin = new Padding(3, 2, 3, 2);
            btn_GURADAR_produc.Name = "btn_GURADAR_produc";
            btn_GURADAR_produc.Size = new Size(108, 49);
            btn_GURADAR_produc.TabIndex = 68;
            btn_GURADAR_produc.Text = "guardar";
            btn_GURADAR_produc.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Window;
            label7.FlatStyle = FlatStyle.Popup;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(567, 28);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 66;
            label7.Text = "HORA DEL SITEMA :";
            // 
            // label_hora_emp
            // 
            label_hora_emp.AutoSize = true;
            label_hora_emp.BackColor = SystemColors.Window;
            label_hora_emp.FlatStyle = FlatStyle.Popup;
            label_hora_emp.ForeColor = SystemColors.ActiveCaptionText;
            label_hora_emp.Location = new Point(715, 28);
            label_hora_emp.Name = "label_hora_emp";
            label_hora_emp.Size = new Size(110, 15);
            label_hora_emp.TabIndex = 65;
            label_hora_emp.Text = "HORA DEL SITEMA ";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = Color.Transparent;
            lbl_Nombre.FlatStyle = FlatStyle.Popup;
            lbl_Nombre.Location = new Point(52, 128);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(56, 15);
            lbl_Nombre.TabIndex = 64;
            lbl_Nombre.Text = "NOMBRE";
            // 
            // lbl_PRECIO
            // 
            lbl_PRECIO.AutoSize = true;
            lbl_PRECIO.BackColor = Color.Transparent;
            lbl_PRECIO.FlatStyle = FlatStyle.Popup;
            lbl_PRECIO.Location = new Point(52, 172);
            lbl_PRECIO.Name = "lbl_PRECIO";
            lbl_PRECIO.Size = new Size(47, 15);
            lbl_PRECIO.TabIndex = 63;
            lbl_PRECIO.Text = "PRECIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Location = new Point(52, 210);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 62;
            label4.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Location = new Point(52, 256);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 61;
            label3.Text = "DESCRIPCON";
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.BackColor = Color.Transparent;
            lbl_codigo.FlatStyle = FlatStyle.Popup;
            lbl_codigo.Location = new Point(52, 78);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(52, 15);
            lbl_codigo.TabIndex = 59;
            lbl_codigo.Text = "CODIGO";
            // 
            // dataGrid_PRODUCTO
            // 
            dataGrid_PRODUCTO.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGrid_PRODUCTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_PRODUCTO.Location = new Point(12, 288);
            dataGrid_PRODUCTO.Margin = new Padding(3, 2, 3, 2);
            dataGrid_PRODUCTO.Name = "dataGrid_PRODUCTO";
            dataGrid_PRODUCTO.Size = new Size(811, 195);
            dataGrid_PRODUCTO.TabIndex = 58;
            dataGrid_PRODUCTO.CellContentClick += dataGrid_PRODUCTO_CellContentClick;
            // 
            // TXT_NOMBRE_product
            // 
            TXT_NOMBRE_product.BackColor = Color.LimeGreen;
            TXT_NOMBRE_product.BorderStyle = BorderStyle.FixedSingle;
            TXT_NOMBRE_product.ForeColor = SystemColors.Window;
            TXT_NOMBRE_product.Location = new Point(120, 126);
            TXT_NOMBRE_product.Margin = new Padding(3, 2, 3, 2);
            TXT_NOMBRE_product.Name = "TXT_NOMBRE_product";
            TXT_NOMBRE_product.Size = new Size(308, 23);
            TXT_NOMBRE_product.TabIndex = 57;
            // 
            // TXT_PRECIO
            // 
            TXT_PRECIO.BackColor = Color.LimeGreen;
            TXT_PRECIO.BorderStyle = BorderStyle.FixedSingle;
            TXT_PRECIO.ForeColor = SystemColors.Window;
            TXT_PRECIO.Location = new Point(124, 172);
            TXT_PRECIO.Margin = new Padding(3, 2, 3, 2);
            TXT_PRECIO.Name = "TXT_PRECIO";
            TXT_PRECIO.Size = new Size(127, 23);
            TXT_PRECIO.TabIndex = 56;
            // 
            // TXT_CANTIDAD
            // 
            TXT_CANTIDAD.BackColor = Color.LimeGreen;
            TXT_CANTIDAD.BorderStyle = BorderStyle.FixedSingle;
            TXT_CANTIDAD.ForeColor = SystemColors.Window;
            TXT_CANTIDAD.Location = new Point(124, 207);
            TXT_CANTIDAD.Margin = new Padding(3, 2, 3, 2);
            TXT_CANTIDAD.Name = "TXT_CANTIDAD";
            TXT_CANTIDAD.Size = new Size(123, 23);
            TXT_CANTIDAD.TabIndex = 55;
            // 
            // TXT_DESCRIPCION
            // 
            TXT_DESCRIPCION.BackColor = Color.LimeGreen;
            TXT_DESCRIPCION.BorderStyle = BorderStyle.FixedSingle;
            TXT_DESCRIPCION.ForeColor = SystemColors.Window;
            TXT_DESCRIPCION.Location = new Point(136, 248);
            TXT_DESCRIPCION.Margin = new Padding(3, 2, 3, 2);
            TXT_DESCRIPCION.Name = "TXT_DESCRIPCION";
            TXT_DESCRIPCION.Size = new Size(308, 23);
            TXT_DESCRIPCION.TabIndex = 54;
            // 
            // TXT_CODIGO_produc
            // 
            TXT_CODIGO_produc.BackColor = Color.LimeGreen;
            TXT_CODIGO_produc.BorderStyle = BorderStyle.FixedSingle;
            TXT_CODIGO_produc.ForeColor = SystemColors.Window;
            TXT_CODIGO_produc.Location = new Point(112, 76);
            TXT_CODIGO_produc.Margin = new Padding(3, 2, 3, 2);
            TXT_CODIGO_produc.Name = "TXT_CODIGO_produc";
            TXT_CODIGO_produc.Size = new Size(185, 23);
            TXT_CODIGO_produc.TabIndex = 52;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(875, 497);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // TXT_FILTRO_PRECIO
            // 
            TXT_FILTRO_PRECIO.BackColor = Color.LimeGreen;
            TXT_FILTRO_PRECIO.BorderStyle = BorderStyle.FixedSingle;
            TXT_FILTRO_PRECIO.ForeColor = SystemColors.Window;
            TXT_FILTRO_PRECIO.Location = new Point(605, 70);
            TXT_FILTRO_PRECIO.Margin = new Padding(3, 2, 3, 2);
            TXT_FILTRO_PRECIO.Name = "TXT_FILTRO_PRECIO";
            TXT_FILTRO_PRECIO.Size = new Size(185, 23);
            TXT_FILTRO_PRECIO.TabIndex = 70;
            // 
            // btn_FILTRAR_product
            // 
            btn_FILTRAR_product.BackColor = Color.FromArgb(0, 0, 64);
            btn_FILTRAR_product.FlatStyle = FlatStyle.Popup;
            btn_FILTRAR_product.ForeColor = SystemColors.Window;
            btn_FILTRAR_product.Location = new Point(603, 172);
            btn_FILTRAR_product.Margin = new Padding(3, 2, 3, 2);
            btn_FILTRAR_product.Name = "btn_FILTRAR_product";
            btn_FILTRAR_product.Size = new Size(108, 49);
            btn_FILTRAR_product.TabIndex = 72;
            btn_FILTRAR_product.Text = "Filtrar";
            btn_FILTRAR_product.UseVisualStyleBackColor = false;
            // 
            // btn_MOSTRAR_TODO_product
            // 
            btn_MOSTRAR_TODO_product.BackColor = Color.FromArgb(0, 0, 64);
            btn_MOSTRAR_TODO_product.FlatStyle = FlatStyle.Popup;
            btn_MOSTRAR_TODO_product.ForeColor = SystemColors.Window;
            btn_MOSTRAR_TODO_product.Location = new Point(603, 235);
            btn_MOSTRAR_TODO_product.Margin = new Padding(3, 2, 3, 2);
            btn_MOSTRAR_TODO_product.Name = "btn_MOSTRAR_TODO_product";
            btn_MOSTRAR_TODO_product.Size = new Size(108, 49);
            btn_MOSTRAR_TODO_product.TabIndex = 74;
            btn_MOSTRAR_TODO_product.Text = "Mostrar todo";
            btn_MOSTRAR_TODO_product.UseVisualStyleBackColor = false;
            // 
            // btn_ELIMINAR_product
            // 
            btn_ELIMINAR_product.BackColor = Color.FromArgb(0, 0, 64);
            btn_ELIMINAR_product.FlatStyle = FlatStyle.Popup;
            btn_ELIMINAR_product.ForeColor = SystemColors.Window;
            btn_ELIMINAR_product.Location = new Point(489, 193);
            btn_ELIMINAR_product.Margin = new Padding(3, 2, 3, 2);
            btn_ELIMINAR_product.Name = "btn_ELIMINAR_product";
            btn_ELIMINAR_product.Size = new Size(108, 49);
            btn_ELIMINAR_product.TabIndex = 75;
            btn_ELIMINAR_product.Text = "Eliminar";
            btn_ELIMINAR_product.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.FlatStyle = FlatStyle.Popup;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(484, 78);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 76;
            label1.Text = "HORA DEL SITEMA :";
            // 
            // FormsProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 491);
            Controls.Add(label1);
            Controls.Add(btn_ELIMINAR_product);
            Controls.Add(btn_MOSTRAR_TODO_product);
            Controls.Add(btn_FILTRAR_product);
            Controls.Add(TXT_FILTRO_PRECIO);
            Controls.Add(BTN_BACK_product);
            Controls.Add(btn_GURADAR_produc);
            Controls.Add(label7);
            Controls.Add(label_hora_emp);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_PRECIO);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_codigo);
            Controls.Add(dataGrid_PRODUCTO);
            Controls.Add(TXT_NOMBRE_product);
            Controls.Add(TXT_PRECIO);
            Controls.Add(TXT_CANTIDAD);
            Controls.Add(TXT_DESCRIPCION);
            Controls.Add(TXT_CODIGO_produc);
            Controls.Add(pictureBox1);
            Name = "FormsProducto";
            Text = "FormsProducto";
            Load += FormsProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_PRODUCTO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_BACK_product;
        private Button btn_GURADAR_produc;
        private Label label7;
        private Label label_hora_emp;
        private Label lbl_Nombre;
        private Label lbl_PRECIO;
        private Label label4;
        private Label label3;
        private Label lbl_codigo;
        private DataGridView dataGrid_PRODUCTO;
        private TextBox TXT_NOMBRE_product;
        private TextBox TXT_PRECIO;
        private TextBox TXT_CANTIDAD;
        private TextBox TXT_DESCRIPCION;
        private TextBox TXT_CODIGO_produc;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox TXT_FILTRO_PRECIO;
        private Button btn_FILTRAR_product;
        private Button btn_MOSTRAR_TODO_product;
        private Button btn_ELIMINAR_product;
        private Label label1;
    }
}