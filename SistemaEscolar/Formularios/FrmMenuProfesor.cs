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
using System.IO;
using SistemaEscolar.Properties;

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
            try
            {
                lblNombreUsuario.Text = FrmLogin.nombreProfesor;

                byte[] foto = null;
                foto = FrmLogin.fotoPerfilProfesor;

                MemoryStream mem = new MemoryStream(foto);

                Bitmap bitmap = new Bitmap(mem);

                pbFotoPerfil.Image = bitmap;
            }
            catch (Exception Ex)
            {
                try
                {
                    if (File.Exists("profile.png"))
                    {
                        FileStream fs = new System.IO.FileStream("profile.png", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        pbFotoPerfil.Image = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al cargar foto" + Ex.Message);
                }
                
                Console.WriteLine("Error al cargar foto" + Ex.Message);
            }
            
        }

        private void btnGruposP_Click(object sender, EventArgs e)
        {
            FrmVisualizarCursos frmVC = new FrmVisualizarCursos();
            frmVC.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVisualizarAlumnos frmVA = new FrmVisualizarAlumnos();
            frmVA.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCreditos frmC = new FrmCreditos();
            frmC.ShowDialog();            
        }
    }
}
