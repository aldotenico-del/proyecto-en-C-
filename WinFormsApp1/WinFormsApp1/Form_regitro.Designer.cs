namespace WinFormsApp1
{
    partial class Formregitro
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
            label1 = new Label();
            label2 = new Label();
            TXT_USUARIO2 = new TextBox();
            TXT_PAS2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(39, 143);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "CREAR USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(141, 19);
            label2.TabIndex = 1;
            label2.Text = "CREAR CONTRASEÑA";
            // 
            // TXT_USUARIO2
            // 
            TXT_USUARIO2.Location = new Point(167, 140);
            TXT_USUARIO2.Name = "TXT_USUARIO2";
            TXT_USUARIO2.Size = new Size(219, 26);
            TXT_USUARIO2.TabIndex = 2;
            // 
            // TXT_PAS2
            // 
            TXT_PAS2.Location = new Point(167, 189);
            TXT_PAS2.Name = "TXT_PAS2";
            TXT_PAS2.Size = new Size(185, 26);
            TXT_PAS2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(180, 242);
            button1.Name = "button1";
            button1.Size = new Size(145, 33);
            button1.TabIndex = 4;
            button1.Text = "Reguistrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 378);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(180, 303);
            button2.Name = "button2";
            button2.Size = new Size(145, 33);
            button2.TabIndex = 8;
            button2.Text = "ATRAS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Formregitro
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(510, 378);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TXT_PAS2);
            Controls.Add(TXT_USUARIO2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Formregitro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGITRO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TXT_USUARIO2;
        private TextBox TXT_PAS2;
        private Button button1;
      
        private Button button2;
        private PictureBox pictureBox1;
      
    }
}