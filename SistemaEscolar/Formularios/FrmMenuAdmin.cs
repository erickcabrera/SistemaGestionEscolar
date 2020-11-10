using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscolar.Formularios;
using System.Runtime.InteropServices;
using System.IO;

namespace SistemaEscolar.Formularios
{
    public partial class FrmMenuAdmin : Form
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

        public FrmMenuAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FormMenuPrueba_Load(object sender, EventArgs e)
        {
            try
            {
                btnEstudiantes.Focus();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(resultado == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.Show();
            }else if(resultado == DialogResult.No)
            {
                MessageBox.Show("Continue con su sesión...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormMenuPrueba_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FrmAlumno frmA = new FrmAlumno();
            frmA.Show();
            this.Hide();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FrmProfesor frmP = new FrmProfesor();
            frmP.Show();
            this.Hide();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FrmMateria frmM = new FrmMateria();
            frmM.Show();
            this.Hide();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FrmDetalleGradoSeccion f = new FrmDetalleGradoSeccion();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmSecciones frmS = new FrmSecciones();
            frmS.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCursos frmC = new FrmCursos();
            frmC.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmCreditos frmC = new FrmCreditos();
            frmC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMatriculaAlumno frmMatricula = new FrmMatriculaAlumno();
            this.Hide();
            frmMatricula.Show();
        }

        private void btnGrados_Click(object sender, EventArgs e)
        {
            FrmGrado frmGrado = new FrmGrado();
            this.Hide();
            frmGrado.Show();
        }
    }
}
