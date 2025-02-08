using System.Runtime.InteropServices;
using LaBaratosa.Operations;

namespace LaBaratosa
{
    public partial class Login : Form
    {
        private static Database _database = new("DSN=LaBaratosa");



        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
              int nLeft,
              int nTop,
              int nRight,
              int nBottom,
              int nWidthEllipse,
              int nHeihtEllipse
            );

        private void Ptransp_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Ptransp.BackColor = Color.FromArgb(100, 204, 102, 0);
            btnAcceder.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAcceder.Width, btnAcceder.Height, 30, 30));
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            try
            {
                Usuario user = _database.VerifyCredentials(username, password);

                if (user != null)
                {
                    MessageBox.Show("Ha iniciado sesion de forma exitosa!");
                    Thread.Sleep(1000);
                    MainMenu formu = new MainMenu(username);
                    formu.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contrase�a no validos.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if (Show.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}