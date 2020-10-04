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


namespace SistemaEscolar.Formularios
{
    public partial class FormMenuPrueba : Form
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

        public FormMenuPrueba()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FormMenuPrueba_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido " + FrmLogin.nombreProfesor.ToString() + " con codigo "+ FrmLogin.idProfesor.ToString());
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo);
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
    }
}
