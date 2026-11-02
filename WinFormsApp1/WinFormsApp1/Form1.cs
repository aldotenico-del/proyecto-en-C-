namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // LAMBDA DE EXPRESIÓN: botón SALIR del sistema
            BTN_END.Click -= BTN_END_Click;
            BTN_END.Click += (s, ev) => Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_LOG_Click(object sender, EventArgs e)
        {
            string user = TXT_USER1.Text.Trim();
            string password = TXT_PAS1.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, completa usuario y contraseña.");
                return;
            }

            string url = "C:\\Users\\user\\OneDrive - Universidad Central del Este\\documentos de la UCE\\MIDEL.COD\\preyectos en C#\\capenta\\" + user + ".txt";

            if (!File.Exists(url))
            {
                MessageBox.Show("El usuario no existe.");
                TXT_PAS1.Clear();
                return;
            }

            string passwordGuardada = File.ReadAllText(url);

            if (password == passwordGuardada)
            {
                MessageBox.Show("Bienvenido, " + user + ".");

                FormMenuprincipal menu = new FormMenuprincipal();
                menu.FormClosed += (s, args) => this.Close(); // al cerrar el menú, se cierra la app
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.");
                TXT_PAS1.Clear();
                TXT_PAS1.Focus();
            }
        }

        private void BTN_REGI_Click(object sender, EventArgs e)
        {
            Form Formregitro = new Formregitro();
            this.Hide();
            Formregitro.Show();
        }

        private void BTN_END_Click(object sender, EventArgs e)
        {
          
        }
    }
}
