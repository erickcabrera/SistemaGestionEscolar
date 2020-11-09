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
using SistemaEscolar.Formularios;

namespace SistemaEscolar
{

    public partial class FrmLogin : Form
    {   
        //VARIABLES GLOBALES
        internal static int idProfesor = 0;
        internal static String nombreProfesor = String.Empty;
        internal static byte[] fotoPerfilProfesor = null;

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

        public FrmLogin()
        {
            InitializeComponent();
           this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            //texto
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void IniciarSesion()
        {
            if (txtContra.Text == "" && txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar su usuario y contraseña", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtContra.Text == "")
                {
                    MessageBox.Show("Debe ingresar su contraseña", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtUsuario.Text == "")
                    {
                        MessageBox.Show("Debe ingresar su usuario", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            Sesion sesion = new Sesion();
                            sesion.Nivel = sesion.Iniciar(txtUsuario.Text, txtContra.Text);
                            if (sesion.Nivel == 1)
                            {
                                idProfesor = sesion.ExtraerID(txtUsuario.Text, txtContra.Text);
                                nombreProfesor = sesion.ExtraerNombre(txtUsuario.Text, txtContra.Text);
                                fotoPerfilProfesor = sesion.ExtraerFoto(txtUsuario.Text, txtContra.Text);
                                
                                FrmMenuAdmin formMenuPrueba = new FrmMenuAdmin();
                                formMenuPrueba.Show();
                                this.Hide();
                            }
                            else if (sesion.Nivel == 2)
                            {
                                idProfesor = sesion.ExtraerID(txtUsuario.Text, txtContra.Text);
                                nombreProfesor = sesion.ExtraerNombre(txtUsuario.Text, txtContra.Text);
                                fotoPerfilProfesor = sesion.ExtraerFoto(txtUsuario.Text, txtContra.Text);
                                MenuProfesor menuProfesor = new MenuProfesor();
                                menuProfesor.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuario ó contraseña incorrecta", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception Ex)
                        {
                            Console.WriteLine("Error: " + Ex.Message);
                        }
                    }
                }
            }
        }
        
        private void BtnIngresar(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                IniciarSesion();
            }
        }

        private void TxtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                IniciarSesion();
            }
        }
    }
}
