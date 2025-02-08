using LaBaratosa.Operations;
using System.Runtime.InteropServices;
using GestionDeEmpleados;

namespace LaBaratosa;


public partial class MainMenu : Form
{
    private static Database _database = new("DSN=LaBaratosa");
    private readonly string _accessUser;
    public MainMenu(string accessUser)
    {
        InitializeComponent();
        _accessUser = accessUser;
        if (_database.IsUserManagerOrAdmin(_accessUser))
        {
            mEmployees.Visible = true;
            mStock.Visible = true;
        }
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);


    private void btnFerrateria_Click(object sender, EventArgs e)
    {
        MessageBox.Show(Convert.ToString(_database.fetchAllEmployees()));
    }


    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void PFerreteria_Paint(object sender, PaintEventArgs e)
    {
    }

    private void PAlmacenamiento_Paint(object sender, PaintEventArgs e)
    {
    }

    private void PAlmacenamiento_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void mEmployees_Click(object sender, EventArgs e)
    {
        ManageEmployees next = new ManageEmployees();
        next.Show();
        Thread.Sleep(1000);
        this.Hide();
    }

    private void mStock_Click(object sender, EventArgs e)
    {
    }
}