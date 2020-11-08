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
using SistemaEscolar.Clases;

namespace SistemaEscolar.Formularios
{
    public partial class FrmAlumno : Form
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
        public FrmAlumno()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ActualizarDataGrid()
        {
            Alumno alumno = new Alumno();
            dgvDatosAlumnos.DataSource = null;
            dgvDatosAlumnos.DataSource = alumno.Mostrar();
            dgvDatosAlumnos.ClearSelection();
        }

        private void Limpiar()
        {
            txtNombreA.Clear();
            txtApellidoA.Clear();
            dtpFechanacimiento.Value = DateTime.Now;
            mtxtNIEA.Clear();
            mtxtNumPartidaA.Text = String.Empty;
            mtxtTelefonoA.Clear();
            txtPadre.Clear();
            txtMadre.Clear();
            cmbSexoA.SelectedIndex = -1;
            txtEncargado.Clear();
            rtbDireccionA.Clear();
            pbFotoProfesor.Image = null;
            pbFotoProfesor.BackgroundImage = null;
            txtFoto.Text = "Seleccionar foto...";

            txtNombreA.Focus();
            lblIdAlumno.Text = "";
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            BorrarMensaje();
            dtpFechanacimiento.Value.ToString("yyyy-MM-dd");
            try
            {
                ActualizarDataGrid();
                btnEditarA.Enabled = false;
                btnEliminarA.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message);
            }
        }

        //validar que la fecha de nacimiento no sea mayor a la fecha del sistema
        private bool ValidarFechaySexo()

        {
            DateTime FechaNacimiento= dtpFechanacimiento.Value;
            bool validarF = true;


            if (FechaNacimiento > System.DateTime.Now.Date )
            {
                validarF = false;
                errorProvider1.SetError(dtpFechanacimiento, "La fecha no puede ser mayor a la fecha de este día");
                
            }
            if(cmbSexoA.SelectedIndex==-1)
            {
                validarF = false;
                errorProvider1.SetError(cmbSexoA, "Este campo no puede estar vacío");
            }
            return validarF;
        }
        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuAdmin frmMP = new FrmMenuAdmin();
            frmMP.Show();
            this.Hide();
        }

        private void txtNombreA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombreA, "En este campo sólo se permiten letras");
            }
        }

        private bool validarCampos()
        {
            //esta variable verifica si se está validando algo
            bool validado = true;
            //if para validar camppos vacíos en el formulario de Alumno
            if(txtApellidoA.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtApellidoA, "Ingresar los apellidos del alumno");
            }
           

            if(mtxtNIEA.MaskFull){ }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtNIEA, "Ingresar el número de NIE del alumno");
            }

            if(txtPadre.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtPadre, "Ingresar el nombre del padre");
            }
            if(txtMadre.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtMadre, "Ingresar el nombre de la madre");
            }
            if(txtEncargado.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtEncargado, "Ingresar el nombre del encargado");
            }
            if (txtNombreA.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtNombreA, "Ingresar el nombre del alumno");
            }
            if(mtxtNumPartidaA.MaskFull){ }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtNumPartidaA, "Ingresar el número de partida de nacimiento");
            }

            if (mtxtTelefonoA.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtTelefonoA, "Ingresar el número de teléfono del alumno");
            }
            if(rtbDireccionA.Text=="")
            {
                validado = false;
                errorProvider1.SetError(rtbDireccionA, "Proporcione una dirección de vivienda");
            }
            return validado;

        }

        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtApellidoA, "");
            errorProvider1.SetError(txtPadre, "");
            errorProvider1.SetError(mtxtNIEA, "");
            errorProvider1.SetError(txtMadre, "");
            errorProvider1.SetError(txtNombreA, "");
            errorProvider1.SetError(mtxtNumPartidaA, "");
            errorProvider1.SetError(mtxtTelefonoA, "");
            errorProvider1.SetError(txtEncargado, "");
            errorProvider1.SetError(rtbDireccionA, "");
        }

        private void txtApellidoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtApellidoA, "En este campo sólo se permiten letras");
            }
        }

        private void btnGuardarA_Click(object sender, EventArgs e)
        {
            //validaciones
            BorrarMensaje();
            if (validarCampos() && ValidarFechaySexo())
            {
                //creo un objeto de la clase persona y guardo a través de las propiedades 
                if (txtFoto.Text == "Seleccionar foto...")
                {
                    MessageBox.Show("Debe seleccionar una foto");
                }
                else
                {
                    try
                    {
                        Alumno alumno = new Alumno();

                        alumno.Nombres = txtNombreA.Text;
                        alumno.Apellidos = txtApellidoA.Text;
                        alumno.FechaNac = Convert.ToString(dtpFechanacimiento.Value.ToString("yyyy-MM-dd"));
                        alumno.Telefono = mtxtTelefonoA.Text;
                        alumno.Nie = mtxtNIEA.Text;
                        alumno.NumPartida = mtxtNumPartidaA.Text;
                        alumno.NombrePadre = txtPadre.Text;
                        alumno.NombreMadre = txtMadre.Text;
                        alumno.NombreEncargado = txtEncargado.Text;
                        alumno.Sexo = cmbSexoA.Text;
                        alumno.Direccion = rtbDireccionA.Text;

                        String sourceFile = txtFoto.Text;
                        String destinationFile = "Fotos\\" + alumno.Nombres + " - " + alumno.Nie + ".png";

                        System.IO.File.Copy(sourceFile, "..\\..\\" + destinationFile);

                        alumno.Foto = destinationFile;

                        if (alumno.Agregar(alumno.Nombres, alumno.Apellidos, alumno.FechaNac, alumno.Sexo, alumno.Telefono, alumno.Direccion, alumno.NumPartida, alumno.Nie,
                            alumno.NombrePadre, alumno.NombreMadre, alumno.NombreEncargado, alumno.Foto) == true)
                        {
                            MessageBox.Show("Los datos se han ingresado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarDataGrid();
                            Limpiar();
                            btnEliminarA.Enabled = false;
                            btnGuardarA.Enabled = true;
                            btnEditarA.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el registro");
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Error al registrar el alumno" + Ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");

            }
        }

        private void txtPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtPadre, "En este campo sólo se permiten letras");
            }
        }

        private void txtMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtMadre, "En este campo sólo se permiten letras");
            }
        }

        private void txtEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtEncargado, "En este campo sólo se permiten letras");
            }
        }

        private void picBMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvDatosAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatosAlumnos.SelectedRows.Count > 0)
            {
                try
                {
                    Limpiar();
                    btnEditarA.Enabled = false;
                    btnEliminarA.Enabled = true;
                    btnGuardarA.Enabled = true;
                    lblIdAlumno.Text = dgvDatosAlumnos.CurrentRow.Cells["Num"].Value.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void txtFoto_Click(object sender, EventArgs e)
        {
            openFileFoto.InitialDirectory = "C:\\";
            openFileFoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            try
            {
                if (openFileFoto.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFileFoto.FileName;
                    txtFoto.Text = sourceFile;

                    System.IO.FileStream fs = new System.IO.FileStream(sourceFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    pbFotoProfesor.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                    btnGuardarA.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarA_Click(object sender, EventArgs e)
        {
            if (dgvDatosAlumnos.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro numero " + lblIdAlumno.Text + "?", "SALIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Alumno alumno = new Alumno();

                    if (alumno.Eliminar(int.Parse(lblIdAlumno.Text)) == true)
                    {
                        MessageBox.Show("El alumno ha sido eliminado correctamente");
                        ActualizarDataGrid();
                        Limpiar();
                        btnEliminarA.Enabled = false;
                        btnGuardarA.Enabled = true;
                        btnEditarA.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el alumno");
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    btnEliminarA.Enabled = false;
                    dgvDatosAlumnos.ClearSelection();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = new Alumno();

                dgvDatosAlumnos.DataSource = null;
                dgvDatosAlumnos.DataSource = alumno.Buscar(txtBuscar.Text.Trim());
                dgvDatosAlumnos.ClearSelection();
                txtBuscar.Focus();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al buscar datos" + Ex.Message);
            }
        }

        private void dgvDatosAlumnos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDatosAlumnos.SelectedRows.Count > 0)
            {
                lblIdAlumno.Text = dgvDatosAlumnos.CurrentRow.Cells["Num"].Value.ToString();
                txtNombreA.Text = dgvDatosAlumnos.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellidoA.Text = dgvDatosAlumnos.CurrentRow.Cells["Apellidos"].Value.ToString();
                dtpFechanacimiento.Value = DateTime.Parse(dgvDatosAlumnos.CurrentRow.Cells["Fecha de nacimiento"].Value.ToString());
                mtxtTelefonoA.Text = dgvDatosAlumnos.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEncargado.Text = dgvDatosAlumnos.CurrentRow.Cells["Encargado"].Value.ToString();
                txtPadre.Text = dgvDatosAlumnos.CurrentRow.Cells["Padre"].Value.ToString();
                txtMadre.Text = dgvDatosAlumnos.CurrentRow.Cells["Madre"].Value.ToString();
                mtxtNIEA.Text = dgvDatosAlumnos.CurrentRow.Cells["NIE"].Value.ToString();
                mtxtNumPartidaA.Text = dgvDatosAlumnos.CurrentRow.Cells["Num. Partida"].Value.ToString();
                cmbSexoA.Text = dgvDatosAlumnos.CurrentRow.Cells["Sexo"].Value.ToString();
                rtbDireccionA.Text = dgvDatosAlumnos.CurrentRow.Cells["Direccion"].Value.ToString();

                Alumno alumno = new Alumno();

                try
                {
                    string idAlumno = lblIdAlumno.Text;
                    string ruta = alumno.ExtraerFoto(idAlumno);
                    Image image = Image.FromFile(@"..\\..\\" + ruta);
                    this.pbFotoProfesor.Image = image;
                    this.lblRutaFoto.Text = ruta;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cargar foto " + ex.Message);
                }

                btnEditarA.Enabled = true;
                btnEliminarA.Enabled = false;
                btnGuardarA.Enabled = false;
                txtNombreA.Focus();
                dgvDatosAlumnos.CurrentCell.Selected = false;
                dgvDatosAlumnos.ClearSelection();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnEditarA_Click(object sender, EventArgs e)
        {
            //validaciones
            BorrarMensaje();
            if (validarCampos() && ValidarFechaySexo())
            {
                try
                {
                    Alumno alumno = new Alumno();

                    alumno.Nombres = txtNombreA.Text;
                    alumno.Apellidos = txtApellidoA.Text;
                    alumno.FechaNac = Convert.ToString(dtpFechanacimiento.Value.ToString("yyyy-MM-dd"));
                    alumno.Telefono = mtxtTelefonoA.Text;
                    alumno.Nie = mtxtNIEA.Text;
                    alumno.NumPartida = mtxtNumPartidaA.Text;
                    alumno.NombrePadre = txtPadre.Text;
                    alumno.NombreMadre = txtMadre.Text;
                    alumno.NombreEncargado = txtEncargado.Text;
                    alumno.Sexo = cmbSexoA.Text;
                    alumno.Direccion = rtbDireccionA.Text;

                    if (txtFoto.Text != "Seleccionar foto...")
                    {
                        String sourceFile = txtFoto.Text;
                        String destinationFile = "Fotos\\" + alumno.Nombres + " - " + alumno.Nie + ".png";

                        System.IO.File.Copy(sourceFile, "..\\..\\" + destinationFile);
                        alumno.Foto = destinationFile;
                    }
                    else
                    {
                        alumno.Foto = lblRutaFoto.Text;
                    }
                    if (alumno.Modificar(int.Parse(lblIdAlumno.Text), alumno.Nombres, alumno.Apellidos, alumno.FechaNac, alumno.Sexo, alumno.Telefono, alumno.Direccion, alumno.NumPartida, alumno.Nie,
                            alumno.NombrePadre, alumno.NombreMadre, alumno.NombreEncargado, alumno.Foto) == true)
                    {
                        MessageBox.Show("Los datos se han modificado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                        Limpiar();
                        lblIdAlumno.Text = "";
                        lblRutaFoto.Text = "";
                        btnEditarA.Enabled = false;
                        btnGuardarA.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el registro");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al modificar datos" + Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }
    }
}
