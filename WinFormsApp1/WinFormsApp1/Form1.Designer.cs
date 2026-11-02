namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTN_END = new Button();
            BTN_LOG = new Button();
            BTN_REGI = new Button();
            label1 = new Label();
            label2 = new Label();
            TXT_USER1 = new TextBox();
            TXT_PAS1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTN_END
            // 
            BTN_END.Location = new Point(228, 352);
            BTN_END.Name = "BTN_END";
            BTN_END.Size = new Size(150, 41);
            BTN_END.TabIndex = 0;
            BTN_END.Text = "salir";
            BTN_END.UseVisualStyleBackColor = true;
            BTN_END.Click += BTN_END_Click;
            // 
            // BTN_LOG
            // 
            BTN_LOG.Location = new Point(228, 257);
            BTN_LOG.Name = "BTN_LOG";
            BTN_LOG.Size = new Size(150, 40);
            BTN_LOG.TabIndex = 1;
            BTN_LOG.Text = "ingresar";
            BTN_LOG.UseVisualStyleBackColor = true;
            BTN_LOG.Click += BTN_LOG_Click;
            // 
            // BTN_REGI
            // 
            BTN_REGI.Location = new Point(228, 303);
            BTN_REGI.Name = "BTN_REGI";
            BTN_REGI.Size = new Size(150, 43);
            BTN_REGI.TabIndex = 2;
            BTN_REGI.Text = "Registrar";
            BTN_REGI.UseVisualStyleBackColor = true;
            BTN_REGI.Click += BTN_REGI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 106);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 3;
            label1.Text = "USUARIO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 192);
            label2.Name = "label2";
            label2.Size = new Size(100, 19);
            label2.TabIndex = 4;
            label2.Text = "CONTRASEÑA ";
            // 
            // TXT_USER1
            // 
            TXT_USER1.Location = new Point(218, 106);
            TXT_USER1.Name = "TXT_USER1";
            TXT_USER1.Size = new Size(257, 26);
            TXT_USER1.TabIndex = 6;
            // 
            // TXT_PAS1
            // 
            TXT_PAS1.Location = new Point(218, 185);
            TXT_PAS1.Name = "TXT_PAS1";
            TXT_PAS1.PasswordChar = '.';
            TXT_PAS1.Size = new Size(178, 26);
            TXT_PAS1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.BackgroundImage = Properties.Resources.images;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(570, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 479);
            Controls.Add(TXT_PAS1);
            Controls.Add(TXT_USER1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTN_REGI);
            Controls.Add(BTN_LOG);
            Controls.Add(BTN_END);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO DE SECION ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_END;
        private Button BTN_LOG;
        private Button BTN_REGI;
        private Label label1;
        private Label label2;
        private TextBox TXT_USER1;
        private TextBox TXT_PAS1;
        private PictureBox pictureBox1;
    }
}
