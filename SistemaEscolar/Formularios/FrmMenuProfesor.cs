using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaEscolar.Formularios
{
    public partial class MenuProfesor : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );

        public MenuProfesor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void MenuProfesor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.Show();
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Continue con su sesión...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuProfesor_Load(object sender, EventArgs e)
        {
            //FrmLogin.fotoPerfilProfesor.ToString()
            string ruta = "";
            ruta = "..\\..\\" + FrmLogin.fotoPerfilProfesor.ToString();
            System.IO.FileStream fs = new System.IO.FileStream(ruta, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            pbFotoPerfil.Image = System.Drawing.Image.FromStream(fs);
            lblNombreUsuario.Text = FrmLogin.nombreProfesor.ToString();
            fs.Close();
            //MessageBox.Show("Bienvenido " + FrmLogin.nombreProfesor.ToString() + " con codigo " + FrmLogin.idProfesor.ToString());
        }

        private void btnGruposP_Click(object sender, EventArgs e)
        {

        }
    }
}
