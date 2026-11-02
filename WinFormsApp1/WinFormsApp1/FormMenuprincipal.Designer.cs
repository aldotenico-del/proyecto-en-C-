namespace WinFormsApp1
{
    partial class FormMenuprincipal
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
            menuStrip1 = new MenuStrip();
            eMPLEADOToolStripMenuItem = new ToolStripMenuItem();
            rESGITRAREMPLEADOToolStripMenuItem = new ToolStripMenuItem();
            cLIENTEToolStripMenuItem = new ToolStripMenuItem();
            rEGITRODECLIENTEToolStripMenuItem = new ToolStripMenuItem();
            iNVENTARIOToolStripMenuItem = new ToolStripMenuItem();
            iNTEGRARINVENTARIOToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            LBL_HORA = new Label();
            BTN_END = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pRODUCTOToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { eMPLEADOToolStripMenuItem, cLIENTEToolStripMenuItem, iNVENTARIOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // eMPLEADOToolStripMenuItem
            // 
            eMPLEADOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rESGITRAREMPLEADOToolStripMenuItem });
            eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            eMPLEADOToolStripMenuItem.Size = new Size(80, 20);
            eMPLEADOToolStripMenuItem.Text = "EMPLEADO";
            // 
            // rESGITRAREMPLEADOToolStripMenuItem
            // 
            rESGITRAREMPLEADOToolStripMenuItem.Name = "rESGITRAREMPLEADOToolStripMenuItem";
            rESGITRAREMPLEADOToolStripMenuItem.Size = new Size(197, 22);
            rESGITRAREMPLEADOToolStripMenuItem.Text = "RESGITRAR EMPLEADO";
            rESGITRAREMPLEADOToolStripMenuItem.Click += rESGITRAREMPLEADOToolStripMenuItem_Click;
            // 
            // cLIENTEToolStripMenuItem
            // 
            cLIENTEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rEGITRODECLIENTEToolStripMenuItem });
            cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            cLIENTEToolStripMenuItem.Size = new Size(64, 20);
            cLIENTEToolStripMenuItem.Text = "CLIENTE";
            // 
            // rEGITRODECLIENTEToolStripMenuItem
            // 
            rEGITRODECLIENTEToolStripMenuItem.Name = "rEGITRODECLIENTEToolStripMenuItem";
            rEGITRODECLIENTEToolStripMenuItem.Size = new Size(186, 22);
            rEGITRODECLIENTEToolStripMenuItem.Text = "REGITRO DE CLIENTE";
            rEGITRODECLIENTEToolStripMenuItem.Click += rEGITRODECLIENTEToolStripMenuItem_Click;
            // 
            // iNVENTARIOToolStripMenuItem
            // 
            iNVENTARIOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iNTEGRARINVENTARIOToolStripMenuItem, pRODUCTOToolStripMenuItem });
            iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
            iNVENTARIOToolStripMenuItem.Size = new Size(86, 20);
            iNVENTARIOToolStripMenuItem.Text = "INVENTARIO";
            // 
            // iNTEGRARINVENTARIOToolStripMenuItem
            // 
            iNTEGRARINVENTARIOToolStripMenuItem.Name = "iNTEGRARINVENTARIOToolStripMenuItem";
            iNTEGRARINVENTARIOToolStripMenuItem.Size = new Size(199, 22);
            iNTEGRARINVENTARIOToolStripMenuItem.Text = "INTEGRAR INVENTARIO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images;
            pictureBox2.Location = new Point(0, 24);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(700, 332);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 73);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 7;
            label1.Text = "hora del sistema:";
            // 
            // LBL_HORA
            // 
            LBL_HORA.AutoSize = true;
            LBL_HORA.Location = new Point(532, 73);
            LBL_HORA.Name = "LBL_HORA";
            LBL_HORA.Size = new Size(31, 15);
            LBL_HORA.TabIndex = 8;
            LBL_HORA.Text = "hora";
            // 
            // BTN_END
            // 
            BTN_END.Location = new Point(16, 75);
            BTN_END.Margin = new Padding(3, 2, 3, 2);
            BTN_END.Name = "BTN_END";
            BTN_END.Size = new Size(131, 32);
            BTN_END.TabIndex = 9;
            BTN_END.Text = "salir";
            BTN_END.UseVisualStyleBackColor = true;
            BTN_END.Click += BTN_END_Click;
            // 
            // button2
            // 
            button2.Location = new Point(16, 28);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(127, 26);
            button2.TabIndex = 10;
            button2.Text = "ATRAS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(BTN_END);
            groupBox1.Location = new Point(516, 194);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(167, 146);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pRODUCTOToolStripMenuItem
            // 
            pRODUCTOToolStripMenuItem.Name = "pRODUCTOToolStripMenuItem";
            pRODUCTOToolStripMenuItem.Size = new Size(199, 22);
            pRODUCTOToolStripMenuItem.Text = "PRODUCTO";
            pRODUCTOToolStripMenuItem.Click += pRODUCTOToolStripMenuItem_Click_1;
            // 
            // FormMenuprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 355);
            Controls.Add(groupBox1);
            Controls.Add(LBL_HORA);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenuprincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuprincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem eMPLEADOToolStripMenuItem;
        private ToolStripMenuItem cLIENTEToolStripMenuItem;
        private ToolStripMenuItem rEGITRODECLIENTEToolStripMenuItem;
        private ToolStripMenuItem iNVENTARIOToolStripMenuItem;
        private PictureBox pictureBox2;
        private Label label1;
        private Label LBL_HORA;
        private Button BTN_END;
        private Button button2;
        private GroupBox groupBox1;
        private ToolStripMenuItem rESGITRAREMPLEADOToolStripMenuItem;
        private ToolStripMenuItem iNTEGRARINVENTARIOToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem pRODUCTOToolStripMenuItem;
    }
}